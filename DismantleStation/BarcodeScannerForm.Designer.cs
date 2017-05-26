namespace DismantleStation
{
    partial class BarcodeScannerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tbRead = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPortName = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbError = new System.Windows.Forms.TextBox();
            this.btnSerialOpenClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tbRead
            // 
            this.tbRead.Location = new System.Drawing.Point(6, 19);
            this.tbRead.Multiline = true;
            this.tbRead.Name = "tbRead";
            this.tbRead.Size = new System.Drawing.Size(598, 152);
            this.tbRead.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.tbRead);
            this.groupBox1.Location = new System.Drawing.Point(27, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 187);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Read";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(489, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate";
            // 
            // lblPortName
            // 
            this.lblPortName.AutoSize = true;
            this.lblPortName.Location = new System.Drawing.Point(161, 13);
            this.lblPortName.Name = "lblPortName";
            this.lblPortName.Size = new System.Drawing.Size(35, 13);
            this.lblPortName.TabIndex = 2;
            this.lblPortName.Text = "label1";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(161, 35);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(35, 13);
            this.lblBaudRate.TabIndex = 2;
            this.lblBaudRate.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbError);
            this.groupBox2.Location = new System.Drawing.Point(27, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 104);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Error";
            // 
            // tbError
            // 
            this.tbError.Location = new System.Drawing.Point(6, 19);
            this.tbError.Multiline = true;
            this.tbError.Name = "tbError";
            this.tbError.Size = new System.Drawing.Size(592, 75);
            this.tbError.TabIndex = 0;
            // 
            // btnSerialOpenClose
            // 
            this.btnSerialOpenClose.Location = new System.Drawing.Point(506, 31);
            this.btnSerialOpenClose.Name = "btnSerialOpenClose";
            this.btnSerialOpenClose.Size = new System.Drawing.Size(139, 48);
            this.btnSerialOpenClose.TabIndex = 4;
            this.btnSerialOpenClose.Text = "CONNECT";
            this.btnSerialOpenClose.UseVisualStyleBackColor = true;
            this.btnSerialOpenClose.Click += new System.EventHandler(this.btnSerialOpenClose_Click);
            // 
            // BarcodeScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 395);
            this.Controls.Add(this.btnSerialOpenClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblBaudRate);
            this.Controls.Add(this.lblPortName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "BarcodeScannerForm";
            this.Text = "BarcodeScannerForm";
            this.Load += new System.EventHandler(this.BarcodeScannerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox tbRead;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPortName;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbError;
        private System.Windows.Forms.Button btnSerialOpenClose;
    }
}