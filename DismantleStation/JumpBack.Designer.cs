namespace DismantleStation
{
    partial class JumpBack
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbPrevProcess = new System.Windows.Forms.ComboBox();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.Color.White;
            this.gb1.Controls.Add(this.cbPrevProcess);
            this.gb1.Controls.Add(this.btnUpdate);
            this.gb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.Location = new System.Drawing.Point(24, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(925, 137);
            this.gb1.TabIndex = 4;
            this.gb1.TabStop = false;
            this.gb1.Text = "Jump To Station";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(780, 42);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 55);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "&UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbPrevProcess
            // 
            this.cbPrevProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrevProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrevProcess.FormattingEnabled = true;
            this.cbPrevProcess.Location = new System.Drawing.Point(43, 45);
            this.cbPrevProcess.Name = "cbPrevProcess";
            this.cbPrevProcess.Size = new System.Drawing.Size(720, 50);
            this.cbPrevProcess.TabIndex = 1;
            // 
            // JumpBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 162);
            this.Controls.Add(this.gb1);
            this.Name = "JumpBack";
            this.Text = "JumpBack";
            this.Load += new System.EventHandler(this.JumpBack_Load);
            this.gb1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.ComboBox cbPrevProcess;
    }
}