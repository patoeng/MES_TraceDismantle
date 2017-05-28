using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Traceability.Hook.Models;



namespace DismantleStation
{
    public partial class DismantleForm : Form
    {
        public delegate void DelegateSetLabelText(Label label, string info);
        public delegate void DelegateSetLabelTextBox(TextBox label, string info);
        public delegate void DelegateSeButtonVisible(Button label, bool info);
        private TraceabilityConnector.TraceabilityConnector _thisTraceabilityConnector;
        private BarcodeScannerForm _barcodeScanner;
        private ProductProcessWithDetails _productProcess=new ProductProcessWithDetails();
        private int _currentRoleId = -1;
        private readonly string _dbConnection = new Settings1().DbConnection;
        private ProductRename _productRenameForm;


        public DismantleForm()
        {
            InitializeComponent();
            InitTraceability();
            InitBarcode();
        }

        private void InitTraceability()
        {
            _thisTraceabilityConnector = new TraceabilityConnector.TraceabilityConnector(true);
        }

        private void InitBarcode()
        {
            if (_barcodeScanner != null)
            {
                _barcodeScanner.DataMatrixReadEvent -= DataMatrixReadEvent;
            }
            _barcodeScanner = new BarcodeScannerForm();
            _barcodeScanner.DataMatrixReadEvent += DataMatrixReadEvent;
            _barcodeScanner.Connect();
            if (!_barcodeScanner.IsConnected())
            {
                MessageBox.Show(@"Failed to Open Barcode Port", @"Initialize", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DataMatrixReadEvent(string data, BarcodeScanningMode mode)
        {
            if (mode == BarcodeScanningMode.Dismantle)
            {
                SetLabelTextBox(tbReadBarcode, data);
                GetProductLastStatus2(data);
            }
            if (mode == BarcodeScanningMode.RenameNewName)
            {
                if (_productRenameForm != null)
                {
                    SetLabelTextBox(_productRenameForm.tbReadBarcode, data);
                }
            }
        }
        private void SetLabelTextBox(TextBox label, string text)
        {
            if (label.InvokeRequired)
            {
                DelegateSetLabelTextBox d = SetLabelTextBox;
                Invoke(d, label, text);
            }
            else
            {
                label.Text = text;
            }
        }
        private void SetLabelText(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                DelegateSetLabelText d = SetLabelText;
                Invoke(d, label, text);
            }
            else
            {
                label.Text = text;
            }
        }
       
        private void btnTraceability_Click(object sender, EventArgs e)
        {
            _thisTraceabilityConnector?.Show();
        }

        private void tmrScanner_Tick(object sender, EventArgs e)
        {
            lbl_Jam.Text = DateTime.Now.ToString("F");
        }

        private void DismantleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBarcodeScanner_Click(object sender, EventArgs e)
        {
            if (_barcodeScanner == null)
            {
               InitBarcode();
            }
            _barcodeScanner?.ShowDialog();
        }

        private bool GetProductLastStatus(string dataMatrix)
        {

            return _thisTraceabilityConnector.GetProductByDataMatrix(dataMatrix, out _productProcess);
        }
        private void GetProductLastStatus2(string datamatrix)
        {
            ClearProductProcessLabels();
            if (GetProductLastStatus(datamatrix))
            {
                ShowProductProcessLabels();
                return;
            }
            MessageBox.Show(@"Failed To Get Product Information!", @"Get Product Last Status", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        private void btnGetStatus_Click(object sender, EventArgs e)
        {
            GetProductLastStatus2(tbReadBarcode.Text);
        }
        
        private void ShowProductProcessLabels()
        {
            SetLabelText(lblDataMatrix,_productProcess.DataMatrix);
            SetLabelText(lblMachine, _productProcess.MachineName);
            SetLabelText(lblWorkorder,_productProcess.WorkOrderNumber);
            SetLabelText(lblDateTime, _productProcess.DateTime.ToString("F"));
            SetLabelText(lblProduct, _productProcess.Reference);
            if (_productProcess.Result == ProcessResult.Dismantled || _productProcess.Result == ProcessResult.BackJumped)
            {
                SetLabelText(lblStatus, _productProcess.Result +" => Ulangi process di "+_productProcess.MachineName);
            }
            else
            {
                if (_productProcess.Result == ProcessResult.Renamed)
                {
                    SetLabelText(lblStatus,
                        _productProcess.Result + " => from : " + _productProcess.Remarks);
                }
                else
                {
                    SetLabelText(lblStatus, _productProcess.Result.ToString());
                }
            }
        }
        private void ClearProductProcessLabels()
        {
            SetLabelText(lblDataMatrix, string.Empty);
            SetLabelText(lblMachine, string.Empty);
            SetLabelText(lblWorkorder, string.Empty);
            SetLabelText(lblDateTime, string.Empty);
            SetLabelText(lblProduct, string.Empty);
            SetLabelText(lblStatus, string.Empty);
        }

       
        private void btnDismantle_Click(object sender, EventArgs e)
        {
            if (!(_currentRoleId == 0 || _currentRoleId == 2))
            {
                MessageBox.Show(@"Anda tidak mempunyai izin untuk dismantle!", @"Dismantling", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = _thisTraceabilityConnector.ProductDismantle(_productProcess.DataMatrix);
            if (!result)
            {
                MessageBox.Show(@"Dismantle data Failed!", @"Dismantling", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(@"Dismantle data Successfull!", @"Dismantling", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            if (_thisTraceabilityConnector.GetProductByDataMatrix(_productProcess.DataMatrix, out _productProcess))
            {
                ShowProductProcessLabels();               
            }

        }

       private void btnClear_Click(object sender, EventArgs e)
        {
            _productProcess = new ProductProcessWithDetails();
            ClearProductProcessLabels();
            tbReadBarcode.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.Text.Contains("Log In"))
            {
                using (UserLogin loginForm = new UserLogin())
                {
                    loginForm.ShowDialog();
                    _currentRoleId = loginForm.LoginResult;
                    UserControlsHelper.SetFormAccess(this, _currentRoleId, _dbConnection);
                    if (_currentRoleId >= 0)
                    {
                        lblUserName.Text = ((UserLevels) _currentRoleId).ToString();
                        btnLogin.Text = @"&Log Out";
                    }
                }
            }
            else
            {
                if (btnLogin.Text.Contains("Log Out"))
                {
                    _currentRoleId = -1;
                    HideAllButton();
                    btnLogin.Text = @"&Log In";
                    lblUserName.Text = @"user";
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            using (var form = new ChangePassword(_currentRoleId))
            {
                form.ShowDialog();
            }
        }

        private void HideAllButton()
        {
            btnBarcodeScanner.Visible = false;
            btnJumpBack.Visible = false;
            btnTraceability.Visible = false;
            btnRename.Visible = false;
            btnDismantle.Visible = false;
            btnChangePassword.Visible = false;
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            _barcodeScanner.BarcodeScanningMode(BarcodeScanningMode.RenameNewName);
            _productRenameForm = new ProductRename();
            _productRenameForm?.ShowDialog();
            if (_productRenameForm.Rename)
            {
               var j = _thisTraceabilityConnector.ProductRename(_productProcess.DataMatrix, _productRenameForm.NewDataMatrix);
                if (j)
                {
                    GetProductLastStatus2(_productRenameForm.NewDataMatrix);
                    MessageBox.Show(@"Process Rename is successfull");
                }
                else
                {
                    MessageBox.Show(@"Process Rename is failed!");
                }
            }
            _productRenameForm.Dispose();
            _barcodeScanner.BarcodeScanningMode(BarcodeScanningMode.Dismantle);
        }

        private void btnJumpBack_Click(object sender, EventArgs e)
        {
            using (var frm = new JumpBack())
            {
                List<ProductSequenceItem> data;
                var i = _thisTraceabilityConnector.GetPreviousSequenceMachinesByProcessId(_productProcess.Id, out data);
                if (i)
                {
                    foreach (var row in data)
                    {
                        frm.cbPrevProcess.Items.Add(row.MachineFamilyname);
                    }
                    frm.cbPrevProcess.SelectedIndex = 0;
                }
                frm.ShowDialog();
                if (frm.SelectedProcess > -1)
                {
                    var jumpTo = data[frm.SelectedProcess].MachineFamilyId??0;
                    var j = _thisTraceabilityConnector.ProductProcessJumpBack(_productProcess.Id, jumpTo);
                    if (j)
                    {
                        GetProductLastStatus2(_productProcess.DataMatrix);
                        MessageBox.Show(@"Process Jump Back is successfull");
                    }
                    else
                    {
                        MessageBox.Show(@"Process Jump Back is failed!");
                    }
                }
            }
        }
    }
}
