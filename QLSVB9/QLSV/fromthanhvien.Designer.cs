namespace QLSV
{
    partial class fromthanhvien
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
            this.lbltongtv = new System.Windows.Forms.Label();
            this.txttongthanhvien = new System.Windows.Forms.TextBox();
            this.dvgdanhsach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgdanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltongtv
            // 
            this.lbltongtv.AutoSize = true;
            this.lbltongtv.Location = new System.Drawing.Point(40, 140);
            this.lbltongtv.Name = "lbltongtv";
            this.lbltongtv.Size = new System.Drawing.Size(60, 16);
            this.lbltongtv.TabIndex = 0;
            this.lbltongtv.Text = "Tổng TV";
            // 
            // txttongthanhvien
            // 
            this.txttongthanhvien.Location = new System.Drawing.Point(106, 137);
            this.txttongthanhvien.Name = "txttongthanhvien";
            this.txttongthanhvien.Size = new System.Drawing.Size(202, 22);
            this.txttongthanhvien.TabIndex = 1;
            // 
            // dvgdanhsach
            // 
            this.dvgdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgdanhsach.Location = new System.Drawing.Point(349, 82);
            this.dvgdanhsach.Name = "dvgdanhsach";
            this.dvgdanhsach.RowHeadersWidth = 51;
            this.dvgdanhsach.RowTemplate.Height = 24;
            this.dvgdanhsach.Size = new System.Drawing.Size(429, 312);
            this.dvgdanhsach.TabIndex = 2;
            // 
            // fromthanhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dvgdanhsach);
            this.Controls.Add(this.txttongthanhvien);
            this.Controls.Add(this.lbltongtv);
            this.Name = "fromthanhvien";
            this.Text = "fromthanhvien";
      
            ((System.ComponentModel.ISupportInitialize)(this.dvgdanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltongtv;
        private System.Windows.Forms.TextBox txttongthanhvien;
        private System.Windows.Forms.DataGridView dvgdanhsach;
    }
}