namespace KiemTra
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
            this.grbthongtinsinhvien = new System.Windows.Forms.GroupBox();
            this.txtdiemthi = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtdiemquatrinh = new System.Windows.Forms.TextBox();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lbldiemquatrinh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmasv = new System.Windows.Forms.Label();
            this.grbchucnang = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnsvm = new System.Windows.Forms.Button();
            this.dvgsinhvien = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbthongtinsinhvien.SuspendLayout();
            this.grbchucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgsinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // grbthongtinsinhvien
            // 
            this.grbthongtinsinhvien.Controls.Add(this.txtdiemthi);
            this.grbthongtinsinhvien.Controls.Add(this.txthoten);
            this.grbthongtinsinhvien.Controls.Add(this.txtdiemquatrinh);
            this.grbthongtinsinhvien.Controls.Add(this.txtmasv);
            this.grbthongtinsinhvien.Controls.Add(this.lblhoten);
            this.grbthongtinsinhvien.Controls.Add(this.lbldiemquatrinh);
            this.grbthongtinsinhvien.Controls.Add(this.label2);
            this.grbthongtinsinhvien.Controls.Add(this.lblmasv);
            this.grbthongtinsinhvien.Location = new System.Drawing.Point(24, 37);
            this.grbthongtinsinhvien.Name = "grbthongtinsinhvien";
            this.grbthongtinsinhvien.Size = new System.Drawing.Size(328, 318);
            this.grbthongtinsinhvien.TabIndex = 0;
            this.grbthongtinsinhvien.TabStop = false;
            this.grbthongtinsinhvien.Text = "Thông tin sinh viên";
            // 
            // txtdiemthi
            // 
            this.txtdiemthi.Location = new System.Drawing.Point(26, 268);
            this.txtdiemthi.Name = "txtdiemthi";
            this.txtdiemthi.Size = new System.Drawing.Size(207, 22);
            this.txtdiemthi.TabIndex = 7;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(26, 124);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(207, 22);
            this.txthoten.TabIndex = 6;
            // 
            // txtdiemquatrinh
            // 
            this.txtdiemquatrinh.Location = new System.Drawing.Point(26, 198);
            this.txtdiemquatrinh.Name = "txtdiemquatrinh";
            this.txtdiemquatrinh.Size = new System.Drawing.Size(207, 22);
            this.txtdiemquatrinh.TabIndex = 5;
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(26, 46);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(207, 22);
            this.txtmasv.TabIndex = 4;
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(23, 105);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(52, 16);
            this.lblhoten.TabIndex = 3;
            this.lblhoten.Text = "Họ Tên";
            // 
            // lbldiemquatrinh
            // 
            this.lbldiemquatrinh.AutoSize = true;
            this.lbldiemquatrinh.Location = new System.Drawing.Point(23, 179);
            this.lbldiemquatrinh.Name = "lbldiemquatrinh";
            this.lbldiemquatrinh.Size = new System.Drawing.Size(91, 16);
            this.lbldiemquatrinh.TabIndex = 2;
            this.lbldiemquatrinh.Text = "Điểm quá trình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm Thi (Báo cáo)";
            // 
            // lblmasv
            // 
            this.lblmasv.AutoSize = true;
            this.lblmasv.Location = new System.Drawing.Point(23, 27);
            this.lblmasv.Name = "lblmasv";
            this.lblmasv.Size = new System.Drawing.Size(47, 16);
            this.lblmasv.TabIndex = 0;
            this.lblmasv.Text = "Mã SV";
            // 
            // grbchucnang
            // 
            this.grbchucnang.Controls.Add(this.btnthoat);
            this.grbchucnang.Controls.Add(this.btnxoa);
            this.grbchucnang.Controls.Add(this.btnsua);
            this.grbchucnang.Controls.Add(this.btnsvm);
            this.grbchucnang.Location = new System.Drawing.Point(27, 372);
            this.grbchucnang.Name = "grbchucnang";
            this.grbchucnang.Size = new System.Drawing.Size(715, 66);
            this.grbchucnang.TabIndex = 1;
            this.grbchucnang.TabStop = false;
            this.grbchucnang.Text = "Chức năng";
            this.grbchucnang.Enter += new System.EventHandler(this.grbchucnang_Enter);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(572, 23);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(118, 28);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(391, 23);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(118, 28);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(218, 23);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(118, 28);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnsvm
            // 
            this.btnsvm.Location = new System.Drawing.Point(24, 23);
            this.btnsvm.Name = "btnsvm";
            this.btnsvm.Size = new System.Drawing.Size(118, 28);
            this.btnsvm.TabIndex = 0;
            this.btnsvm.Text = "Sinh viên mới";
            this.btnsvm.UseVisualStyleBackColor = true;
            this.btnsvm.Click += new System.EventHandler(this.btnsvm_Click);
            // 
            // dvgsinhvien
            // 
            this.dvgsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgsinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.DiemQT,
            this.DiemThi});
            this.dvgsinhvien.Location = new System.Drawing.Point(387, 49);
            this.dvgsinhvien.Name = "dvgsinhvien";
            this.dvgsinhvien.RowHeadersWidth = 51;
            this.dvgsinhvien.RowTemplate.Height = 24;
            this.dvgsinhvien.Size = new System.Drawing.Size(355, 288);
            this.dvgsinhvien.TabIndex = 2;
         
            // 
            // MaSV
            // 
            this.MaSV.HeaderText = "Mã SV";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 125;
            // 
            // DiemQT
            // 
            this.DiemQT.HeaderText = "Điểm QT";
            this.DiemQT.MinimumWidth = 6;
            this.DiemQT.Name = "DiemQT";
            this.DiemQT.Width = 125;
            // 
            // DiemThi
            // 
            this.DiemThi.HeaderText = "Điểm Thi";
            this.DiemThi.MinimumWidth = 6;
            this.DiemThi.Name = "DiemThi";
            this.DiemThi.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.dvgsinhvien);
            this.Controls.Add(this.grbchucnang);
            this.Controls.Add(this.grbthongtinsinhvien);
            this.Name = "Form1";
            this.Text = "Tính điểm học phần";
            this.grbthongtinsinhvien.ResumeLayout(false);
            this.grbthongtinsinhvien.PerformLayout();
            this.grbchucnang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgsinhvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbthongtinsinhvien;
        private System.Windows.Forms.TextBox txtdiemthi;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtdiemquatrinh;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lbldiemquatrinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmasv;
        private System.Windows.Forms.GroupBox grbchucnang;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnsvm;
        private System.Windows.Forms.DataGridView dvgsinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi;
    }
}

