namespace bai5_6
{
    partial class TTSV
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
            dtbngaysinh = new DateTimePicker();
            cbxkhoa = new ComboBox();
            txthoten = new TextBox();
            txtmasv = new TextBox();
            lblkhoa = new Label();
            lblngaysinh = new Label();
            lblhoten = new Label();
            lblmasv = new Label();
            lblttsv = new Label();
            grbchucnang = new GroupBox();
            btnthoat = new Button();
            btnxoa = new Button();
            btncapnhat = new Button();
            btnthem = new Button();
            grbdanhsach = new GroupBox();
            dvgdanhsach = new DataGridView();
            MaSV = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            Khoa = new DataGridViewTextBoxColumn();
            grbthongtin.SuspendLayout();
            grbchucnang.SuspendLayout();
            grbdanhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgdanhsach).BeginInit();
            SuspendLayout();
            // 
            // grbthongtin
            // 
            grbthongtin.Controls.Add(dtbngaysinh);
            grbthongtin.Controls.Add(cbxkhoa);
            grbthongtin.Controls.Add(txthoten);
            grbthongtin.Controls.Add(txtmasv);
            grbthongtin.Controls.Add(lblkhoa);
            grbthongtin.Controls.Add(lblngaysinh);
            grbthongtin.Controls.Add(lblhoten);
            grbthongtin.Controls.Add(lblmasv);
            grbthongtin.Location = new Point(27, 93);
            grbthongtin.Name = "grbthongtin";
            grbthongtin.Size = new Size(677, 137);
            grbthongtin.TabIndex = 0;
            grbthongtin.TabStop = false;
            grbthongtin.Text = "THÔNG TIN";
            // 
            // dtbngaysinh
            // 
            dtbngaysinh.Location = new Point(442, 27);
            dtbngaysinh.Name = "dtbngaysinh";
            dtbngaysinh.Size = new Size(202, 27);
            dtbngaysinh.TabIndex = 8;
            // 
            // cbxkhoa
            // 
            cbxkhoa.FormattingEnabled = true;
            cbxkhoa.Items.AddRange(new object[] { "CNTT", "QTKD", "Kế toán", "Ngoại ngữ" });
            cbxkhoa.Location = new Point(441, 85);
            cbxkhoa.Name = "cbxkhoa";
            cbxkhoa.Size = new Size(204, 28);
            cbxkhoa.TabIndex = 7;
            cbxkhoa.SelectedIndexChanged += cbxkhoa_SelectedIndexChanged;
            // 
            // txthoten
            // 
            txthoten.Location = new Point(95, 87);
            txthoten.Name = "txthoten";
            txthoten.Size = new Size(185, 27);
            txthoten.TabIndex = 5;
            // 
            // txtmasv
            // 
            txtmasv.Location = new Point(95, 27);
            txtmasv.Name = "txtmasv";
            txtmasv.Size = new Size(185, 27);
            txtmasv.TabIndex = 4;
            // 
            // lblkhoa
            // 
            lblkhoa.AutoSize = true;
            lblkhoa.Location = new Point(355, 87);
            lblkhoa.Name = "lblkhoa";
            lblkhoa.Size = new Size(50, 20);
            lblkhoa.TabIndex = 3;
            lblkhoa.Text = "KHOA";
            // 
            // lblngaysinh
            // 
            lblngaysinh.AutoSize = true;
            lblngaysinh.Location = new Point(355, 23);
            lblngaysinh.Name = "lblngaysinh";
            lblngaysinh.Size = new Size(85, 20);
            lblngaysinh.TabIndex = 2;
            lblngaysinh.Text = "NGÀY SINH";
            // 
            // lblhoten
            // 
            lblhoten.AutoSize = true;
            lblhoten.Location = new Point(27, 87);
            lblhoten.Name = "lblhoten";
            lblhoten.Size = new Size(62, 20);
            lblhoten.TabIndex = 1;
            lblhoten.Text = "HỌ TÊN";
            // 
            // lblmasv
            // 
            lblmasv.AutoSize = true;
            lblmasv.Location = new Point(27, 31);
            lblmasv.Name = "lblmasv";
            lblmasv.Size = new Size(53, 20);
            lblmasv.TabIndex = 0;
            lblmasv.Text = "MÃ SV";
            // 
            // lblttsv
            // 
            lblttsv.AutoSize = true;
            lblttsv.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblttsv.ForeColor = Color.Red;
            lblttsv.Location = new Point(203, 28);
            lblttsv.Name = "lblttsv";
            lblttsv.Size = new Size(322, 41);
            lblttsv.TabIndex = 1;
            lblttsv.Text = "THÔNG TIN SINH VIÊN";
            lblttsv.Click += label1_Click;
            // 
            // grbchucnang
            // 
            grbchucnang.Controls.Add(btnthoat);
            grbchucnang.Controls.Add(btnxoa);
            grbchucnang.Controls.Add(btncapnhat);
            grbchucnang.Controls.Add(btnthem);
            grbchucnang.Location = new Point(30, 255);
            grbchucnang.Name = "grbchucnang";
            grbchucnang.Size = new Size(677, 61);
            grbchucnang.TabIndex = 2;
            grbchucnang.TabStop = false;
            grbchucnang.Text = "CHỨC NĂNG";
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(570, 28);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(85, 25);
            btnthoat.TabIndex = 3;
            btnthoat.Text = "THOÁT";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(411, 27);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(85, 25);
            btnxoa.TabIndex = 2;
            btnxoa.Text = "XÓA";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btncapnhat
            // 
            btncapnhat.Location = new Point(231, 28);
            btncapnhat.Name = "btncapnhat";
            btncapnhat.Size = new Size(113, 25);
            btncapnhat.TabIndex = 1;
            btncapnhat.Text = "CẬP NHẬT";
            btncapnhat.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(93, 28);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(85, 25);
            btnthem.TabIndex = 0;
            btnthem.Text = "THÊM";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // grbdanhsach
            // 
            grbdanhsach.Controls.Add(dvgdanhsach);
            grbdanhsach.Location = new Point(30, 352);
            grbdanhsach.Name = "grbdanhsach";
            grbdanhsach.Size = new Size(677, 248);
            grbdanhsach.TabIndex = 3;
            grbdanhsach.TabStop = false;
            grbdanhsach.Text = "DANH SÁCH";
            // 
            // dvgdanhsach
            // 
            dvgdanhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgdanhsach.Columns.AddRange(new DataGridViewColumn[] { MaSV, HoTen, NgaySinh, Khoa });
            dvgdanhsach.Dock = DockStyle.Fill;
            dvgdanhsach.Location = new Point(3, 23);
            dvgdanhsach.Margin = new Padding(3, 4, 3, 4);
            dvgdanhsach.Name = "dvgdanhsach";
            dvgdanhsach.RowHeadersWidth = 51;
            dvgdanhsach.RowTemplate.Height = 25;
            dvgdanhsach.Size = new Size(671, 222);
            dvgdanhsach.TabIndex = 0;
            dvgdanhsach.CellContentClick += dvgdanhsach_CellContentClick;
            // 
            // MaSV
            // 
            MaSV.HeaderText = "Mã SV";
            MaSV.MinimumWidth = 6;
            MaSV.Name = "MaSV";
            MaSV.Width = 125;
            // 
            // HoTen
            // 
            HoTen.HeaderText = "Họ Tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.Width = 125;
            // 
            // NgaySinh
            // 
            NgaySinh.HeaderText = "Ngày Sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.Width = 125;
            // 
            // Khoa
            // 
            Khoa.HeaderText = "Khoa";
            Khoa.MinimumWidth = 6;
            Khoa.Name = "Khoa";
            Khoa.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 612);
            Controls.Add(grbdanhsach);
            Controls.Add(grbchucnang);
            Controls.Add(lblttsv);
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
        private Label lblttsv;
        private ComboBox cbxkhoa;
        private TextBox txthoten;
        private TextBox txtmasv;
        private Label lblkhoa;
        private Label lblngaysinh;
        private Label lblhoten;
        private Label lblmasv;
        private GroupBox grbchucnang;
        private Button btnthoat;
        private Button btnxoa;
        private Button btncapnhat;
        private Button btnthem;
        private DateTimePicker dtbngaysinh;
        private GroupBox grbdanhsach;
        private DataGridView dvgdanhsach;
        private DataGridViewTextBoxColumn MaSV;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn Khoa;
    }
}