namespace bai5._3_6
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
            cbxdonvitinh = new ComboBox();
            cbxloaisp = new ComboBox();
            txtmasp = new TextBox();
            txttensp = new TextBox();
            txtsoluong = new TextBox();
            txtgia = new TextBox();
            lblsoluong = new Label();
            lblgia = new Label();
            lblmasp = new Label();
            lbltensp = new Label();
            lplloaisp = new Label();
            lbldonvitinh = new Label();
            grbchucnang = new GroupBox();
            btnxoa = new Button();
            btnthoat = new Button();
            btnloc = new Button();
            btnsua = new Button();
            btnthem = new Button();
            grbdanhsach = new GroupBox();
            dvgdanhsach = new DataGridView();
            MaSP = new DataGridViewTextBoxColumn();
            TenSP = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            LoaiSP = new DataGridViewTextBoxColumn();
            Gia = new DataGridViewTextBoxColumn();
            DonViTinh = new DataGridViewTextBoxColumn();
            label1 = new Label();
            grbthongtin.SuspendLayout();
            grbchucnang.SuspendLayout();
            grbdanhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgdanhsach).BeginInit();
            SuspendLayout();
            // 
            // grbthongtin
            // 
            grbthongtin.Controls.Add(cbxdonvitinh);
            grbthongtin.Controls.Add(cbxloaisp);
            grbthongtin.Controls.Add(txtmasp);
            grbthongtin.Controls.Add(txttensp);
            grbthongtin.Controls.Add(txtsoluong);
            grbthongtin.Controls.Add(txtgia);
            grbthongtin.Controls.Add(lblsoluong);
            grbthongtin.Controls.Add(lblgia);
            grbthongtin.Controls.Add(lblmasp);
            grbthongtin.Controls.Add(lbltensp);
            grbthongtin.Controls.Add(lplloaisp);
            grbthongtin.Controls.Add(lbldonvitinh);
            grbthongtin.Location = new Point(17, 59);
            grbthongtin.Name = "grbthongtin";
            grbthongtin.Size = new Size(770, 100);
            grbthongtin.TabIndex = 0;
            grbthongtin.TabStop = false;
            grbthongtin.Text = "Thông tin";
            // 
            // cbxdonvitinh
            // 
            cbxdonvitinh.FormattingEnabled = true;
            cbxdonvitinh.Location = new Point(597, 56);
            cbxdonvitinh.Name = "cbxdonvitinh";
            cbxdonvitinh.Size = new Size(162, 28);
            cbxdonvitinh.TabIndex = 14;
            // 
            // cbxloaisp
            // 
            cbxloaisp.FormattingEnabled = true;
            cbxloaisp.Items.AddRange(new object[] { "Áo nam", "Áo nữ" });
            cbxloaisp.Location = new Point(338, 60);
            cbxloaisp.Name = "cbxloaisp";
            cbxloaisp.Size = new Size(156, 28);
            cbxloaisp.TabIndex = 13;
            // 
            // txtmasp
            // 
            txtmasp.Location = new Point(72, 20);
            txtmasp.Name = "txtmasp";
            txtmasp.Size = new Size(152, 27);
            txtmasp.TabIndex = 12;
            // 
            // txttensp
            // 
            txttensp.Location = new Point(72, 61);
            txttensp.Name = "txttensp";
            txttensp.Size = new Size(152, 27);
            txttensp.TabIndex = 11;
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(338, 23);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(156, 27);
            txtsoluong.TabIndex = 10;
            // 
            // txtgia
            // 
            txtgia.Location = new Point(597, 16);
            txtgia.Name = "txtgia";
            txtgia.Size = new Size(162, 27);
            txtgia.TabIndex = 9;
            // 
            // lblsoluong
            // 
            lblsoluong.AutoSize = true;
            lblsoluong.Location = new Point(263, 23);
            lblsoluong.Name = "lblsoluong";
            lblsoluong.Size = new Size(69, 20);
            lblsoluong.TabIndex = 8;
            lblsoluong.Text = "Số lượng";
            // 
            // lblgia
            // 
            lblgia.AutoSize = true;
            lblgia.Location = new Point(510, 23);
            lblgia.Name = "lblgia";
            lblgia.Size = new Size(31, 20);
            lblgia.TabIndex = 7;
            lblgia.Text = "Giá";
            // 
            // lblmasp
            // 
            lblmasp.AutoSize = true;
            lblmasp.Location = new Point(16, 23);
            lblmasp.Name = "lblmasp";
            lblmasp.Size = new Size(50, 20);
            lblmasp.TabIndex = 6;
            lblmasp.Text = "Mã SP";
            // 
            // lbltensp
            // 
            lbltensp.AutoSize = true;
            lbltensp.Location = new Point(16, 59);
            lbltensp.Name = "lbltensp";
            lbltensp.Size = new Size(52, 20);
            lbltensp.TabIndex = 5;
            lbltensp.Text = "Tên SP";
            // 
            // lplloaisp
            // 
            lplloaisp.AutoSize = true;
            lplloaisp.Location = new Point(263, 59);
            lplloaisp.Name = "lplloaisp";
            lplloaisp.Size = new Size(57, 20);
            lplloaisp.TabIndex = 4;
            lplloaisp.Text = "Loại SP";
            // 
            // lbldonvitinh
            // 
            lbldonvitinh.AutoSize = true;
            lbldonvitinh.Location = new Point(510, 59);
            lbldonvitinh.Name = "lbldonvitinh";
            lbldonvitinh.Size = new Size(81, 20);
            lbldonvitinh.TabIndex = 3;
            lbldonvitinh.Text = "Đơn vị tính";
            // 
            // grbchucnang
            // 
            grbchucnang.Controls.Add(btnxoa);
            grbchucnang.Controls.Add(btnthoat);
            grbchucnang.Controls.Add(btnloc);
            grbchucnang.Controls.Add(btnsua);
            grbchucnang.Controls.Add(btnthem);
            grbchucnang.Location = new Point(18, 165);
            grbchucnang.Name = "grbchucnang";
            grbchucnang.Size = new Size(770, 87);
            grbchucnang.TabIndex = 1;
            grbchucnang.TabStop = false;
            grbchucnang.Text = "Chức năng";
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(318, 41);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(110, 25);
            btnxoa.TabIndex = 4;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(630, 41);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(110, 25);
            btnthoat.TabIndex = 3;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // btnloc
            // 
            btnloc.Location = new Point(482, 41);
            btnloc.Name = "btnloc";
            btnloc.Size = new Size(110, 25);
            btnloc.TabIndex = 2;
            btnloc.Text = "Lọc";
            btnloc.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(170, 41);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(110, 25);
            btnsua.TabIndex = 1;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(26, 41);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(110, 25);
            btnthem.TabIndex = 0;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            // 
            // grbdanhsach
            // 
            grbdanhsach.Controls.Add(dvgdanhsach);
            grbdanhsach.Location = new Point(17, 258);
            grbdanhsach.Name = "grbdanhsach";
            grbdanhsach.Size = new Size(770, 180);
            grbdanhsach.TabIndex = 1;
            grbdanhsach.TabStop = false;
            grbdanhsach.Text = "Danh sách";
            // 
            // dvgdanhsach
            // 
            dvgdanhsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgdanhsach.Columns.AddRange(new DataGridViewColumn[] { MaSP, TenSP, SoLuong, LoaiSP, Gia, DonViTinh });
            dvgdanhsach.Location = new Point(16, 29);
            dvgdanhsach.Name = "dvgdanhsach";
            dvgdanhsach.RowHeadersWidth = 51;
            dvgdanhsach.RowTemplate.Height = 29;
            dvgdanhsach.Size = new Size(743, 142);
            dvgdanhsach.TabIndex = 0;
            // 
            // MaSP
            // 
            MaSP.HeaderText = "Mã SP";
            MaSP.MinimumWidth = 6;
            MaSP.Name = "MaSP";
            MaSP.Width = 125;
            // 
            // TenSP
            // 
            TenSP.HeaderText = "Tên SP";
            TenSP.MinimumWidth = 6;
            TenSP.Name = "TenSP";
            TenSP.Width = 125;
            // 
            // SoLuong
            // 
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 125;
            // 
            // LoaiSP
            // 
            LoaiSP.HeaderText = "Loại SP";
            LoaiSP.MinimumWidth = 6;
            LoaiSP.Name = "LoaiSP";
            LoaiSP.Width = 125;
            // 
            // Gia
            // 
            Gia.HeaderText = "Giá";
            Gia.MinimumWidth = 6;
            Gia.Name = "Gia";
            Gia.Width = 125;
            // 
            // DonViTinh
            // 
            DonViTinh.HeaderText = "Đơn vị tính";
            DonViTinh.MinimumWidth = 6;
            DonViTinh.Name = "DonViTinh";
            DonViTinh.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 255);
            label1.Location = new Point(236, 15);
            label1.Name = "label1";
            label1.Size = new Size(297, 41);
            label1.TabIndex = 2;
            label1.Text = "QUẢN LÝ BÁN HÀNG";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private ComboBox cbxdonvitinh;
        private ComboBox cbxloaisp;
        private TextBox txtmasp;
        private TextBox txttensp;
        private TextBox txtsoluong;
        private TextBox txtgia;
        private Label lblsoluong;
        private Label lblgia;
        private Label lblmasp;
        private Label lbltensp;
        private Label lplloaisp;
        private Label lbldonvitinh;
        private GroupBox grbchucnang;
        private Button btnthoat;
        private Button btnloc;
        private Button btnsua;
        private Button btnthem;
        private GroupBox grbdanhsach;
        private DataGridView dvgdanhsach;
        private Label label1;
        private Button btnxoa;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn LoaiSP;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewTextBoxColumn DonViTinh;
    }
}