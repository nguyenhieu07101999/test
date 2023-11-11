namespace QLSV
{
    partial class frmDangNhap
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
            this.lbluser = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btndnhap = new System.Windows.Forms.Button();
            this.lblthongbao = new System.Windows.Forms.Label();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(45, 92);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(36, 16);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "User";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(155, 92);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(181, 22);
            this.txtuser.TabIndex = 1;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(45, 146);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(67, 16);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(155, 146);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(181, 22);
            this.txtpassword.TabIndex = 4;
            // 
            // btndnhap
            // 
            this.btndnhap.Location = new System.Drawing.Point(265, 358);
            this.btndnhap.Name = "btndnhap";
            this.btndnhap.Size = new System.Drawing.Size(229, 80);
            this.btndnhap.TabIndex = 5;
            this.btndnhap.Text = "Đăng Nhập";
            this.btndnhap.UseVisualStyleBackColor = true;
            this.btndnhap.Click += new System.EventHandler(this.btndnhap_Click);
            // 
            // lblthongbao
            // 
            this.lblthongbao.AutoSize = true;
            this.lblthongbao.Location = new System.Drawing.Point(69, 229);
            this.lblthongbao.Name = "lblthongbao";
            this.lblthongbao.Size = new System.Drawing.Size(73, 16);
            this.lblthongbao.TabIndex = 6;
            this.lblthongbao.Text = "Thông báo";
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(114, 277);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(151, 37);
            this.btnluu.TabIndex = 7;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(490, 277);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(151, 37);
            this.btnthoat.TabIndex = 8;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.lblthongbao);
            this.Controls.Add(this.btndnhap);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lbluser);
            this.Name = "frmDangNhap";
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btndnhap;
        private System.Windows.Forms.Label lblthongbao;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthoat;
    }
}