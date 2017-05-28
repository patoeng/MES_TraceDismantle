namespace DismantleStation
{
    partial class DismantleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DismantleForm));
            this.btnTraceability = new System.Windows.Forms.Button();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbReadBarcode = new System.Windows.Forms.TextBox();
            this.btnGetStatus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Jam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrScanner = new System.Windows.Forms.Timer(this.components);
            this.btnBarcodeScanner = new System.Windows.Forms.Button();
            this.gbLastPosition = new System.Windows.Forms.GroupBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnJumpBack = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnDismantle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWorkorder = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMachine = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDataMatrix = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.gbMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.gbLastPosition.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTraceability
            // 
            this.btnTraceability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraceability.Location = new System.Drawing.Point(1048, 678);
            this.btnTraceability.Name = "btnTraceability";
            this.btnTraceability.Size = new System.Drawing.Size(115, 55);
            this.btnTraceability.TabIndex = 0;
            this.btnTraceability.Text = "Traceability";
            this.btnTraceability.UseVisualStyleBackColor = true;
            this.btnTraceability.Visible = false;
            this.btnTraceability.Click += new System.EventHandler(this.btnTraceability_Click);
            // 
            // gbMain
            // 
            this.gbMain.BackColor = System.Drawing.Color.White;
            this.gbMain.Controls.Add(this.groupBox1);
            this.gbMain.Location = new System.Drawing.Point(189, 221);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(979, 195);
            this.gbMain.TabIndex = 1;
            this.gbMain.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tbReadBarcode);
            this.groupBox1.Controls.Add(this.btnGetStatus);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 137);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Matrix Read";
            // 
            // tbReadBarcode
            // 
            this.tbReadBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReadBarcode.Location = new System.Drawing.Point(29, 51);
            this.tbReadBarcode.Name = "tbReadBarcode";
            this.tbReadBarcode.Size = new System.Drawing.Size(721, 49);
            this.tbReadBarcode.TabIndex = 0;
            this.tbReadBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGetStatus
            // 
            this.btnGetStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetStatus.Location = new System.Drawing.Point(780, 45);
            this.btnGetStatus.Name = "btnGetStatus";
            this.btnGetStatus.Size = new System.Drawing.Size(115, 55);
            this.btnGetStatus.TabIndex = 0;
            this.btnGetStatus.Text = "&GET STATUS";
            this.btnGetStatus.UseVisualStyleBackColor = true;
            this.btnGetStatus.Click += new System.EventHandler(this.btnGetStatus_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(189, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 100);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DismantleStation.Properties.Resources.sch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.lbl_Jam);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(422, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 100);
            this.panel2.TabIndex = 2;
            // 
            // lbl_Jam
            // 
            this.lbl_Jam.AutoSize = true;
            this.lbl_Jam.Location = new System.Drawing.Point(451, 3);
            this.lbl_Jam.Name = "lbl_Jam";
            this.lbl_Jam.Size = new System.Drawing.Size(35, 13);
            this.lbl_Jam.TabIndex = 1;
            this.lbl_Jam.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "DISMANTLING STATION";
            // 
            // tmrScanner
            // 
            this.tmrScanner.Enabled = true;
            this.tmrScanner.Interval = 1000;
            this.tmrScanner.Tick += new System.EventHandler(this.tmrScanner_Tick);
            // 
            // btnBarcodeScanner
            // 
            this.btnBarcodeScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarcodeScanner.Location = new System.Drawing.Point(927, 678);
            this.btnBarcodeScanner.Name = "btnBarcodeScanner";
            this.btnBarcodeScanner.Size = new System.Drawing.Size(115, 55);
            this.btnBarcodeScanner.TabIndex = 0;
            this.btnBarcodeScanner.Text = "Barcode Scanner";
            this.btnBarcodeScanner.UseVisualStyleBackColor = true;
            this.btnBarcodeScanner.Visible = false;
            this.btnBarcodeScanner.Click += new System.EventHandler(this.btnBarcodeScanner_Click);
            // 
            // gbLastPosition
            // 
            this.gbLastPosition.BackColor = System.Drawing.Color.White;
            this.gbLastPosition.Controls.Add(this.btnRename);
            this.gbLastPosition.Controls.Add(this.btnJumpBack);
            this.gbLastPosition.Controls.Add(this.lblStatus);
            this.gbLastPosition.Controls.Add(this.label6);
            this.gbLastPosition.Controls.Add(this.lblDateTime);
            this.gbLastPosition.Controls.Add(this.btnDismantle);
            this.gbLastPosition.Controls.Add(this.label5);
            this.gbLastPosition.Controls.Add(this.lblWorkorder);
            this.gbLastPosition.Controls.Add(this.lblProduct);
            this.gbLastPosition.Controls.Add(this.label7);
            this.gbLastPosition.Controls.Add(this.label4);
            this.gbLastPosition.Controls.Add(this.lblMachine);
            this.gbLastPosition.Controls.Add(this.label3);
            this.gbLastPosition.Controls.Add(this.lblDataMatrix);
            this.gbLastPosition.Controls.Add(this.label2);
            this.gbLastPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLastPosition.Location = new System.Drawing.Point(189, 422);
            this.gbLastPosition.Margin = new System.Windows.Forms.Padding(10);
            this.gbLastPosition.Name = "gbLastPosition";
            this.gbLastPosition.Padding = new System.Windows.Forms.Padding(10);
            this.gbLastPosition.Size = new System.Drawing.Size(979, 250);
            this.gbLastPosition.TabIndex = 3;
            this.gbLastPosition.TabStop = false;
            this.gbLastPosition.Text = "Product Last Position";
            // 
            // btnRename
            // 
            this.btnRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.Location = new System.Drawing.Point(780, 30);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(194, 55);
            this.btnRename.TabIndex = 2;
            this.btnRename.Text = "&RENAME";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Visible = false;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnJumpBack
            // 
            this.btnJumpBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJumpBack.Location = new System.Drawing.Point(780, 91);
            this.btnJumpBack.Name = "btnJumpBack";
            this.btnJumpBack.Size = new System.Drawing.Size(194, 55);
            this.btnJumpBack.TabIndex = 1;
            this.btnJumpBack.Text = "&PROCESS JUMP BACK";
            this.btnJumpBack.UseVisualStyleBackColor = true;
            this.btnJumpBack.Visible = false;
            this.btnJumpBack.Click += new System.EventHandler(this.btnJumpBack_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(148, 206);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Status";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(148, 176);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(91, 20);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "Date Time";
            // 
            // btnDismantle
            // 
            this.btnDismantle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDismantle.Location = new System.Drawing.Point(780, 152);
            this.btnDismantle.Name = "btnDismantle";
            this.btnDismantle.Size = new System.Drawing.Size(194, 55);
            this.btnDismantle.TabIndex = 0;
            this.btnDismantle.Text = "&DISMANTLE";
            this.btnDismantle.UseVisualStyleBackColor = true;
            this.btnDismantle.Visible = false;
            this.btnDismantle.Click += new System.EventHandler(this.btnDismantle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date Time";
            // 
            // lblWorkorder
            // 
            this.lblWorkorder.AutoSize = true;
            this.lblWorkorder.Location = new System.Drawing.Point(148, 142);
            this.lblWorkorder.Name = "lblWorkorder";
            this.lblWorkorder.Size = new System.Drawing.Size(92, 20);
            this.lblWorkorder.TabIndex = 0;
            this.lblWorkorder.Text = "Workorder";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(148, 108);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(71, 20);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Product";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Work Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Product";
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Location = new System.Drawing.Point(148, 76);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(76, 20);
            this.lblMachine.TabIndex = 0;
            this.lblMachine.Text = "Machine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Machine";
            // 
            // lblDataMatrix
            // 
            this.lblDataMatrix.AutoSize = true;
            this.lblDataMatrix.Location = new System.Drawing.Point(148, 47);
            this.lblDataMatrix.Name = "lblDataMatrix";
            this.lblDataMatrix.Size = new System.Drawing.Size(101, 20);
            this.lblDataMatrix.TabIndex = 0;
            this.lblDataMatrix.Text = "Data Matrix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Matrix";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(189, 678);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 55);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(310, 678);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 55);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "&Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(431, 678);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(115, 55);
            this.btnChangePassword.TabIndex = 6;
            this.btnChangePassword.Text = "Change &Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Visible = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Green;
            this.lblUserName.Location = new System.Drawing.Point(615, 80);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(36, 17);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "user";
            // 
            // DismantleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1384, 862);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.gbLastPosition);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBarcodeScanner);
            this.Controls.Add(this.btnTraceability);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DismantleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dismantle Station";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DismantleForm_Load);
            this.gbMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbLastPosition.ResumeLayout(false);
            this.gbLastPosition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTraceability;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Jam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrScanner;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbReadBarcode;
        private System.Windows.Forms.Button btnBarcodeScanner;
        private System.Windows.Forms.Button btnGetStatus;
        private System.Windows.Forms.GroupBox gbLastPosition;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWorkorder;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDataMatrix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDismantle;
        private System.Windows.Forms.Button btnJumpBack;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblUserName;
    }
}

