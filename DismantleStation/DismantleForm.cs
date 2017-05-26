using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;
using Traceability.Hook.Models;
using TraceabilityConnector;


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

        private void DataMatrixReadEvent(string data)
        {
            SetLabelTextBox(tbReadBarcode, data);
            GetProductLastStatus2(data);
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
        private void SetButtonVisible(Button label, bool text)
        {
            if (label.InvokeRequired)
            {
                DelegateSeButtonVisible d = SetButtonVisible;
                Invoke(d, label, text);
            }
            else
            {
                label.Visible = text;
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
            ShowHideDismantleButton(false);
            if (GetProductLastStatus(datamatrix))
            {
                ShowProductProcessLabels();
                ShowHideDismantleButton(true);
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
            SetLabelText(lblStatus,_productProcess.Result.ToString());
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

        private void ShowHideDismantleButton(bool show)
        {
           SetButtonVisible(btnDismantle, show);
        }
        private void btnDismantle_Click(object sender, EventArgs e)
        {
            
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
                ShowHideDismantleButton(false);
            }

        }

        private void btnForceToPass_Click(object sender, EventArgs e)
        {
            var result = _thisTraceabilityConnector.ForceUpdateProductOk(_productProcess.DataMatrix);
            if (!result)
            {
                MessageBox.Show(@"Force Update Product to Pass data Failed!", @"Dismantling", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(@"Force Update Product to Pass data!", @"Dismantling", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            if (_thisTraceabilityConnector.GetProductByDataMatrix(_productProcess.DataMatrix, out _productProcess))
            {
                ShowProductProcessLabels();
                ShowHideDismantleButton(false);
            }
        }
    }
}
