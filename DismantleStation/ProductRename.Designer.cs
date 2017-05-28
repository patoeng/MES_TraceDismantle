namespace DismantleStation
{
    partial class ProductRename
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
            this.tbReadBarcode = new System.Windows.Forms.TextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.Color.White;
            this.gb1.Controls.Add(this.tbReadBarcode);
            this.gb1.Controls.Add(this.btnRename);
            this.gb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.Location = new System.Drawing.Point(12, 32);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(925, 137);
            this.gb1.TabIndex = 3;
            this.gb1.TabStop = false;
            this.gb1.Text = "New Data Matrix";
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
            // btnRename
            // 
            this.btnRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.Location = new System.Drawing.Point(780, 45);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(115, 55);
            this.btnRename.TabIndex = 0;
            this.btnRename.Text = "&RENAME";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // ProductRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 200);
            this.Controls.Add(this.gb1);
            this.Name = "ProductRename";
            this.Text = "ProductRename";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btnRename;
        public System.Windows.Forms.TextBox tbReadBarcode;
    }
}