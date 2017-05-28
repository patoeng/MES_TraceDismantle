using System;

using System.Windows.Forms;

namespace DismantleStation
{
    public delegate void  DataMatrixRead(string data, BarcodeScanningMode mode);

    public partial class BarcodeScannerForm : Form
    {
        public event DataMatrixRead DataMatrixReadEvent;
        public BarcodeScannerForm()
        {
            InitializeComponent();
            InitializeCom();
        }

        private void BarcodeScannerForm_Load(object sender, EventArgs e)
        {

        }

        private BarcodeScanningMode _barcodeScanningMode;

        public void BarcodeScanningMode(BarcodeScanningMode mode)
        {
            _barcodeScanningMode = mode;
        }
        private string _commNumber;
        private int _baudrate;
        private Settings1 _settings1;
        public void InitializeCom()
        {
            _settings1 = new Settings1();
            _commNumber = _settings1.BarcodeComm;
            _baudrate = _settings1.BarcodeBaudRate;
            lblPortName.Text = _commNumber;
            lblBaudRate.Text = _baudrate.ToString();
        }

        public void Connect()
        {
            serialPort1.PortName = _commNumber;
            serialPort1.BaudRate = _baudrate;
            try
            {
                if (!serialPort1.IsOpen)
                serialPort1.Open();
                tbError.Text = string.Empty;
            }
            catch (Exception exception)
            {
                tbError.Text = DateTime.Now.ToString("F") + @" : Open Port : " + exception.Message;
            }
            if (serialPort1.IsOpen)
            {
                btnSerialOpenClose.Text = @"DISCONNECT";
            }

        }

        public void Disconnect()
        {
            try
            {
                if (serialPort1.IsOpen)
                    serialPort1.Close();
                tbError.Text = string.Empty;
            }
            catch (Exception exception)
            {
                tbError.Text = DateTime.Now.ToString("F") + @" : Open Port : " + exception.Message;
            }
            if (!serialPort1.IsOpen)
            {
                btnSerialOpenClose.Text = @"CONNECT";
            }
        }

        private string _tempBuffer;
        public void ClearTemporaryBuffer()
        {
            _tempBuffer = string.Empty;
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            _tempBuffer += serialPort1.ReadExisting();
            //if (_tempBuffer.Length > 30) return;
            if (!_tempBuffer.Contains("\r")) return;
            if (InvokeRequired)
            {
                Invoke(new DataMatrixRead(BarcodeRead), new object[] { _tempBuffer , _barcodeScanningMode });
            }
            else
            {
                BarcodeRead(_tempBuffer,_barcodeScanningMode);
            }
            _tempBuffer = "";
        }

        private void BarcodeRead(string tempBuffer, BarcodeScanningMode mode)
        {
            tempBuffer = tempBuffer.Trim('\r', '\n');
            if (Visible)
            {
                tbRead.Text = tempBuffer;
            }
            DataMatrixReadEvent?.Invoke(tempBuffer,mode);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbRead.Clear();
        }

        private void btnSerialOpenClose_Click(object sender, EventArgs e)
        {
            var btnOpenClose = (Button) sender;
            if (btnOpenClose.Text.Contains("CONNECT"))
            {
                Connect();
            }
            else
            {
                Disconnect();
            }
        }

        public bool IsConnected()
        {
            return serialPort1.IsOpen;
        }
    }
}
