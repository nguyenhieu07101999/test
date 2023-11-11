namespace QLSVB7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbthongtin = new GroupBox();
            lblmasv = new Label();
            lblhoten = new Label();
            grbchucnang = new GroupBox();
            grbdanhsach = new GroupBox();
            label1 = new Label();
            lblkhoa = new Label();
            lbldiemtb = new Label();
            txtmasv = new TextBox();
            txthoten = new TextBox();
            txtdiemtb = new TextBox();
            btnthem = new Button();
            btnxoa = new Button();
            btnthoat = new Button();
            btnloc = new Button();
            btnluu = new Button();
            btnsua = new Button();
            dvgdanhsach = new DataGridView();
            cbxkhoa = new ComboBox();
            grbthongtin.SuspendLayout();
            grbchucnang.SuspendLayout();
            grbdanhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgdanhsach).BeginInit();
            SuspendLayout();
            // 
            // grbthongtin
            // 
            grbthongtin.Controls.Add(cbxkhoa);
            grbthongtin.Controls.Add(txtdiemtb);
            grbthongtin.Controls.Add(txthoten);
            grbthongtin.Controls.Add(txtmasv);
            grbthongtin.Controls.Add(lbldiemtb);
            grbthongtin.Controls.Add(lblmasv);
            grbthongtin.Controls.Add(lblkhoa);
            grbthongtin.Controls.Add(lblhoten);
            grbthongtin.Location = new Point(15, 74);
            grbthongtin.Name = "grbthongtin";
            grbthongtin.Size = new Size(1128, 161);
            grbthongtin.TabIndex = 0;
            grbthongtin.TabStop = false;
            grbthongtin.Text = "Thông tin";
            // 
            // lblmasv
            // 
            lblmasv.AutoSize = true;
            lblmasv.Location = new Point(24, 36);
            lblmasv.Name = "lblmasv";
            lblmasv.Size = new Size(51, 20);
            lblmasv.TabIndex = 5;
            lblmasv.Text = "Mã SV";
            // 
            // lblhoten
            // 
            lblhoten.AutoSize = true;
            lblhoten.Location = new Point(24, 107);
            lblhoten.Name = "lblhoten";
            lblhoten.Size = new Size(54, 20);
            lblhoten.TabIndex = 4;
            lblhoten.Text = "Họ tên";
            // 
            // grbchucnang
            // 
            grbchucnang.Controls.Add(btnsua);
            grbchucnang.Controls.Add(btnluu);
            grbchucnang.Controls.Add(btnloc);
            grbchucnang.Controls.Add(btnthoat);
            grbchucnang.Controls.Add(btnxoa);
            grbchucnang.Controls.Add(btnthem);
            grbchucnang.Location = new Point(12, 241);
            grbchucnang.Name = "grbchucnang";
            grbchucnang.Size = new Size(1128, 80);
            grbchucnang.TabIndex = 1;
            grbchucnang.TabStop = false;
            grbchucnang.Text = "Chức  năng";
            // 
            // grbdanhsach
            // 
            grbdanhsach.Controls.Add(dvgdanhsach);
            grbdanhsach.Location = new Point(15, 327);
            grbdanhsach.Name = "grbdanhsach";
            grbdanhsach.Size = new Size(1128, 276);
            grbdanhsach.TabIndex = 1;
            grbdanhsach.TabStop = false;
            grbdanhsach.Text = "Danh sách";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 128);
            label1.Location = new Point(396, 9);
            label1.Name = "label1";
            label1.Size = new Size(308, 41);
            label1.TabIndex = 2;
            label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // lblkhoa
            // 
            lblkhoa.AutoSize = true;
            lblkhoa.Location = new Point(579, 36);
            lblkhoa.Name = "lblkhoa";
            lblkhoa.Size = new Size(43, 20);
            lblkhoa.TabIndex = 3;
            lblkhoa.Text = "Khoa";
            lblkhoa.Click += label2_Click;
            // 
            // lbldiemtb
            // 
            lbldiemtb.AutoSize = true;
            lbldiemtb.Location = new Point(579, 107);
            lbldiemtb.Name = "lbldiemtb";
            lbldiemtb.Size = new Size(66, 20);
            lbldiemtb.TabIndex = 6;
            lbldiemtb.Text = "Điểm TB";
            // 
            // txtmasv
            // 
            txtmasv.Location = new Point(125, 36);
            txtmasv.Name = "txtmasv";
            txtmasv.Size = new Size(321, 27);
            txtmasv.TabIndex = 7;
            // 
            // txthoten
            // 
            txthoten.Location = new Point(125, 100);
            txthoten.Name = "txthoten";
            txthoten.Size = new Size(321, 27);
            txthoten.TabIndex = 8;
            // 
            // txtdiemtb
            // 
            txtdiemtb.Location = new Point(653, 100);
            txtdiemtb.Name = "txtdiemtb";
            txtdiemtb.Size = new Size(321, 27);
            txtdiemtb.TabIndex = 9;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(26, 35);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(97, 28);
            btnthem.TabIndex = 0;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(595, 35);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(97, 28);
            btnxoa.TabIndex = 1;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(993, 35);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(97, 28);
            btnthoat.TabIndex = 2;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnloc
            // 
            btnloc.Location = new Point(794, 35);
            btnloc.Name = "btnloc";
            btnloc.Size = new Size(97, 28);
            btnloc.TabIndex = 3;
            btnloc.Text = "Lọc";
            btnloc.UseVisualStyleBackColor = true;
            // 
            // btnluu
            // 
            btnluu.Location = new Point(410, 35);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(97, 28);
            btnluu.TabIndex = 4;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(224, 35);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(97, 28);
            btnsua.TabIndex = 5;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            // 
            // dvgdanhsach
            // 
            dvgdanhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgdanhsach.Location = new Point(15, 32);
            dvgdanhsach.Name = "dvgdanhsach";
            dvgdanhsach.RowHeadersWidth = 51;
            dvgdanhsach.RowTemplate.Height = 29;
            dvgdanhsach.Size = new Size(1093, 237);
            dvgdanhsach.TabIndex = 0;
            // 
            // cbxkhoa
            // 
            cbxkhoa.FormattingEnabled = true;
            cbxkhoa.Location = new Point(653, 33);
            cbxkhoa.Name = "cbxkhoa";
            cbxkhoa.Size = new Size(322, 28);
            cbxkhoa.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 615);
            Controls.Add(label1);
            Controls.Add(grbchucnang);
            Controls.Add(grbdanhsach);
            Controls.Add(grbthongtin);
            Name = "Form1";
            Text = "Form1";
            grbthongtin.ResumeLayout(false);
            grbthongtin.PerformLayout();
            grbchucnang.ResumeLayout(false);
            grbdanhsach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgdanhsach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbthongtin;
        private Label lblmasv;
        private Label lblhoten;
        private GroupBox grbchucnang;
        private GroupBox grbdanhsach;
        private Label label1;
        private Label lblkhoa;
        private Label lbldiemtb;
        private TextBox txtdiemtb;
        private TextBox txthoten;
        private TextBox txtmasv;
        private Button btnsua;
        private Button btnluu;
        private Button btnloc;
        private Button btnthoat;
        private Button btnxoa;
        private Button btnthem;
        private DataGridView dvgdanhsach;
        private ComboBox cbxkhoa;
    }
}