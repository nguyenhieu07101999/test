namespace bai5._2_6
{
    partial class QLSV
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
            txtdiemtb = new TextBox();
            txthoten = new TextBox();
            txtmasv = new TextBox();
            cbxkhoa = new ComboBox();
            lblkhoa = new Label();
            lbldiemtb = new Label();
            lblhoten = new Label();
            lblmasv = new Label();
            grbchucnang = new GroupBox();
            btnthoat = new Button();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            grbdanhsach = new GroupBox();
            dvgdanhsach = new DataGridView();
            MaSV = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            DiemTB = new DataGridViewTextBoxColumn();
            Khoa = new DataGridViewTextBoxColumn();
            label1 = new Label();
            grbthongtin.SuspendLayout();
            grbchucnang.SuspendLayout();
            grbdanhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgdanhsach).BeginInit();
            SuspendLayout();
            // 
            // grbthongtin
            // 
            grbthongtin.Controls.Add(txtdiemtb);
            grbthongtin.Controls.Add(txthoten);
            grbthongtin.Controls.Add(txtmasv);
            grbthongtin.Controls.Add(cbxkhoa);
            grbthongtin.Controls.Add(lblkhoa);
            grbthongtin.Controls.Add(lbldiemtb);
            grbthongtin.Controls.Add(lblhoten);
            grbthongtin.Controls.Add(lblmasv);
            grbthongtin.Location = new Point(12, 59);
            grbthongtin.Name = "grbthongtin";
            grbthongtin.Size = new Size(766, 118);
            grbthongtin.TabIndex = 0;
            grbthongtin.TabStop = false;
            grbthongtin.Text = "Thông tin";
            // 
            // txtdiemtb
            // 
            txtdiemtb.Location = new Point(481, 23);
            txtdiemtb.Name = "txtdiemtb";
            txtdiemtb.Size = new Size(240, 27);
            txtdiemtb.TabIndex = 10;
            // 
            // txthoten
            // 
            txthoten.Location = new Point(92, 73);
            txthoten.Name = "txthoten";
            txthoten.Size = new Size(240, 27);
            txthoten.TabIndex = 9;
            // 
            // txtmasv
            // 
            txtmasv.Location = new Point(92, 23);
            txtmasv.Name = "txtmasv";
            txtmasv.Size = new Size(240, 27);
            txtmasv.TabIndex = 8;
            // 
            // cbxkhoa
            // 
            cbxkhoa.FormattingEnabled = true;
            cbxkhoa.Items.AddRange(new object[] { "CNTT ", "Kế toán", "Ngoại ngữ", "Điện tử" });
            cbxkhoa.Location = new Point(481, 73);
            cbxkhoa.Name = "cbxkhoa";
            cbxkhoa.Size = new Size(240, 28);
            cbxkhoa.TabIndex = 7;
            cbxkhoa.SelectedIndexChanged += cbxkhoa_SelectedIndexChanged;
            // 
            // lblkhoa
            // 
            lblkhoa.AutoSize = true;
            lblkhoa.Location = new Point(396, 73);
            lblkhoa.Name = "lblkhoa";
            lblkhoa.Size = new Size(43, 20);
            lblkhoa.TabIndex = 6;
            lblkhoa.Text = "Khoa";
            // 
            // lbldiemtb
            // 
            lbldiemtb.AutoSize = true;
            lbldiemtb.Location = new Point(396, 23);
            lbldiemtb.Name = "lbldiemtb";
            lbldiemtb.Size = new Size(66, 20);
            lbldiemtb.TabIndex = 5;
            lbldiemtb.Text = "Điểm TB";
            // 
            // lblhoten
            // 
            lblhoten.AutoSize = true;
            lblhoten.Location = new Point(24, 73);
            lblhoten.Name = "lblhoten";
            lblhoten.Size = new Size(54, 20);
            lblhoten.TabIndex = 4;
            lblhoten.Text = "Họ tên";
            // 
            // lblmasv
            // 
            lblmasv.AutoSize = true;
            lblmasv.Location = new Point(24, 23);
            lblmasv.Name = "lblmasv";
            lblmasv.Size = new Size(51, 20);
            lblmasv.TabIndex = 3;
            lblmasv.Text = "Mã SV";
            // 
            // grbchucnang
            // 
            grbchucnang.Controls.Add(btnthoat);
            grbchucnang.Controls.Add(btnxoa);
            grbchucnang.Controls.Add(btnsua);
            grbchucnang.Controls.Add(btnthem);
            grbchucnang.Location = new Point(12, 183);
            grbchucnang.Name = "grbchucnang";
            grbchucnang.Size = new Size(766, 72);
            grbchucnang.TabIndex = 1;
            grbchucnang.TabStop = false;
            grbchucnang.Text = "Chức năng";
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(612, 26);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(109, 31);
            btnthoat.TabIndex = 3;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(436, 26);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(109, 31);
            btnxoa.TabIndex = 2;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(223, 26);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(109, 31);
            btnsua.TabIndex = 1;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(51, 26);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(109, 31);
            btnthem.TabIndex = 0;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // grbdanhsach
            // 
            grbdanhsach.Controls.Add(dvgdanhsach);
            grbdanhsach.Location = new Point(12, 261);
            grbdanhsach.Name = "grbdanhsach";
            grbdanhsach.Size = new Size(766, 159);
            grbdanhsach.TabIndex = 1;
            grbdanhsach.TabStop = false;
            grbdanhsach.Text = "Danh sách";
            // 
            // dvgdanhsach
            // 
            dvgdanhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgdanhsach.Columns.AddRange(new DataGridViewColumn[] { MaSV, HoTen, DiemTB, Khoa });
            dvgdanhsach.Location = new Point(24, 25);
            dvgdanhsach.Name = "dvgdanhsach";
            dvgdanhsach.RowHeadersWidth = 51;
            dvgdanhsach.RowTemplate.Height = 29;
            dvgdanhsach.Size = new Size(722, 118);
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
            HoTen.HeaderText = "Họ tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.Width = 125;
            // 
            // DiemTB
            // 
            DiemTB.HeaderText = "Điểm TB";
            DiemTB.MinimumWidth = 6;
            DiemTB.Name = "DiemTB";
            DiemTB.Width = 125;
            // 
            // Khoa
            // 
            Khoa.HeaderText = "Khoa";
            Khoa.MinimumWidth = 6;
            Khoa.Name = "Khoa";
            Khoa.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 128);
            label1.Location = new Point(261, 15);
            label1.Name = "label1";
            label1.Size = new Size(287, 41);
            label1.TabIndex = 2;
            label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // QLSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(grbchucnang);
            Controls.Add(grbdanhsach);
            Controls.Add(grbthongtin);
            Name = "QLSV";
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
        private Label lblkhoa;
        private Label lbldiemtb;
        private Label lblhoten;
        private Label lblmasv;
        private GroupBox grbchucnang;
        private Button btnthoat;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
        private GroupBox grbdanhsach;
        private DataGridView dvgdanhsach;
        private Label label1;
        private TextBox txtdiemtb;
        private TextBox txthoten;
        private TextBox txtmasv;
        private ComboBox cbxkhoa;
        private DataGridViewTextBoxColumn MaSV;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn DiemTB;
        private DataGridViewTextBoxColumn Khoa;
    }
}