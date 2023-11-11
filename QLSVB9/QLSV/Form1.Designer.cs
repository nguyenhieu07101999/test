namespace QLSV
{
    partial class Form1
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
            this.btndangnhap = new System.Windows.Forms.Button();
            this.lbltendangnhap = new System.Windows.Forms.Label();
            this.msmenu = new System.Windows.Forms.MenuStrip();
            this.btnluu = new System.Windows.Forms.Button();
            this.lblkhoa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btndangnhap
            // 
            this.btndangnhap.Location = new System.Drawing.Point(0, 47);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(68, 18);
            this.btndangnhap.TabIndex = 3;
            // 
            // lbltendangnhap
            // 
            this.lbltendangnhap.AutoSize = true;
            this.lbltendangnhap.Location = new System.Drawing.Point(413, 49);
            this.lbltendangnhap.Name = "lbltendangnhap";
            this.lbltendangnhap.Size = new System.Drawing.Size(98, 16);
            this.lbltendangnhap.TabIndex = 2;
            this.lbltendangnhap.Text = "Tên đăng nhập";
            // 
            // msmenu
            // 
            this.msmenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msmenu.Location = new System.Drawing.Point(0, 0);
            this.msmenu.Name = "msmenu";
            this.msmenu.Size = new System.Drawing.Size(979, 30);
            this.msmenu.TabIndex = 4;
            this.msmenu.Text = "Menu";
            this.msmenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.msmenu_ItemClicked);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(400, 408);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(145, 55);
            this.btnluu.TabIndex = 5;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // lblkhoa
            // 
            this.lblkhoa.AutoSize = true;
            this.lblkhoa.Location = new System.Drawing.Point(19, 143);
            this.lblkhoa.Name = "lblkhoa";
            this.lblkhoa.Size = new System.Drawing.Size(38, 16);
            this.lblkhoa.TabIndex = 6;
            this.lblkhoa.Text = "Khoa";
            this.lblkhoa.Click += new System.EventHandler(this.lblkhoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 588);
            this.Controls.Add(this.lblkhoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.lbltendangnhap);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.msmenu);
            this.MainMenuStrip = this.msmenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Label lbltendangnhap;
        private System.Windows.Forms.MenuStrip msmenu;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Label lblkhoa;
    }
}

