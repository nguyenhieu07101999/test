namespace QLSV
{
    partial class frmKhoa
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
            this.lblmakhoa = new System.Windows.Forms.Label();
            this.lbltenkhoa = new System.Windows.Forms.Label();
            this.lblghichu = new System.Windows.Forms.Label();
            this.txtmakhoa = new System.Windows.Forms.TextBox();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbthongtin = new System.Windows.Forms.GroupBox();
            this.cbxkhoa = new System.Windows.Forms.ComboBox();
            this.grbdanhsach = new System.Windows.Forms.GroupBox();
            this.dvgdanhsach = new System.Windows.Forms.DataGridView();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbchucnang = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.grbthongtin.SuspendLayout();
            this.grbdanhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgdanhsach)).BeginInit();
            this.grbchucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmakhoa
            // 
            this.lblmakhoa.AutoSize = true;
            this.lblmakhoa.Location = new System.Drawing.Point(19, 30);
            this.lblmakhoa.Name = "lblmakhoa";
            this.lblmakhoa.Size = new System.Drawing.Size(60, 16);
            this.lblmakhoa.TabIndex = 0;
            this.lblmakhoa.Text = "Mã Khoa";
            // 
            // lbltenkhoa
            // 
            this.lbltenkhoa.AutoSize = true;
            this.lbltenkhoa.Location = new System.Drawing.Point(14, 79);
            this.lbltenkhoa.Name = "lbltenkhoa";
            this.lbltenkhoa.Size = new System.Drawing.Size(65, 16);
            this.lbltenkhoa.TabIndex = 1;
            this.lbltenkhoa.Text = "Tên Khoa";
            // 
            // lblghichu
            // 
            this.lblghichu.AutoSize = true;
            this.lblghichu.Location = new System.Drawing.Point(19, 138);
            this.lblghichu.Name = "lblghichu";
            this.lblghichu.Size = new System.Drawing.Size(53, 16);
            this.lblghichu.TabIndex = 2;
            this.lblghichu.Text = "Ghi Chú";
            // 
            // txtmakhoa
            // 
            this.txtmakhoa.Location = new System.Drawing.Point(121, 27);
            this.txtmakhoa.Name = "txtmakhoa";
            this.txtmakhoa.Size = new System.Drawing.Size(215, 22);
            this.txtmakhoa.TabIndex = 3;
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(121, 135);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(215, 22);
            this.txtghichu.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(345, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "GHI CHÚ";
            // 
            // grbthongtin
            // 
            this.grbthongtin.Controls.Add(this.cbxkhoa);
            this.grbthongtin.Controls.Add(this.txtghichu);
            this.grbthongtin.Controls.Add(this.txtmakhoa);
            this.grbthongtin.Controls.Add(this.lblghichu);
            this.grbthongtin.Controls.Add(this.lbltenkhoa);
            this.grbthongtin.Controls.Add(this.lblmakhoa);
            this.grbthongtin.Location = new System.Drawing.Point(46, 64);
            this.grbthongtin.Name = "grbthongtin";
            this.grbthongtin.Size = new System.Drawing.Size(357, 181);
            this.grbthongtin.TabIndex = 7;
            this.grbthongtin.TabStop = false;
            this.grbthongtin.Text = "Thông tin";
            // 
            // cbxkhoa
            // 
            this.cbxkhoa.FormattingEnabled = true;
            this.cbxkhoa.Items.AddRange(new object[] {
            "CNTT",
            "Kế toán",
            "Cơ Khí"});
            this.cbxkhoa.Location = new System.Drawing.Point(121, 79);
            this.cbxkhoa.Name = "cbxkhoa";
            this.cbxkhoa.Size = new System.Drawing.Size(213, 24);
            this.cbxkhoa.TabIndex = 5;
            // 
            // grbdanhsach
            // 
            this.grbdanhsach.Controls.Add(this.dvgdanhsach);
            this.grbdanhsach.Location = new System.Drawing.Point(437, 62);
            this.grbdanhsach.Name = "grbdanhsach";
            this.grbdanhsach.Size = new System.Drawing.Size(350, 182);
            this.grbdanhsach.TabIndex = 8;
            this.grbdanhsach.TabStop = false;
            this.grbdanhsach.Text = "Danh sách";
            // 
            // dvgdanhsach
            // 
            this.dvgdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgdanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoa,
            this.TenKhoa,
            this.GhiChu});
            this.dvgdanhsach.Location = new System.Drawing.Point(19, 21);
            this.dvgdanhsach.Name = "dvgdanhsach";
            this.dvgdanhsach.RowHeadersWidth = 51;
            this.dvgdanhsach.RowTemplate.Height = 24;
            this.dvgdanhsach.Size = new System.Drawing.Size(325, 149);
            this.dvgdanhsach.TabIndex = 0;
            this.dvgdanhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgdanhsach_CellContentClick);
            // 
            // MaKhoa
            // 
            this.MaKhoa.HeaderText = "Mã Khoa";
            this.MaKhoa.MinimumWidth = 6;
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.Width = 125;
            // 
            // TenKhoa
            // 
            this.TenKhoa.HeaderText = "Tên Khoa";
            this.TenKhoa.MinimumWidth = 6;
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.Width = 125;
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 125;
            // 
            // grbchucnang
            // 
            this.grbchucnang.Controls.Add(this.btnxoa);
            this.grbchucnang.Controls.Add(this.btnthoat);
            this.grbchucnang.Controls.Add(this.btnluu);
            this.grbchucnang.Controls.Add(this.btnsua);
            this.grbchucnang.Controls.Add(this.btnthem);
            this.grbchucnang.Location = new System.Drawing.Point(46, 305);
            this.grbchucnang.Name = "grbchucnang";
            this.grbchucnang.Size = new System.Drawing.Size(741, 133);
            this.grbchucnang.TabIndex = 9;
            this.grbchucnang.TabStop = false;
            this.grbchucnang.Text = "Chức năng";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(305, 48);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(93, 37);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(621, 48);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(93, 37);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(459, 48);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(93, 37);
            this.btnluu.TabIndex = 2;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(156, 48);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(93, 37);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(22, 48);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(93, 37);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // frmKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbchucnang);
            this.Controls.Add(this.grbdanhsach);
            this.Controls.Add(this.grbthongtin);
            this.Controls.Add(this.label1);
            this.Name = "frmKhoa";
            this.Text = "frmKhoa";
            this.Load += new System.EventHandler(this.frmKhoa_Load);
            this.grbthongtin.ResumeLayout(false);
            this.grbthongtin.PerformLayout();
            this.grbdanhsach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgdanhsach)).EndInit();
            this.grbchucnang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmakhoa;
        private System.Windows.Forms.Label lbltenkhoa;
        private System.Windows.Forms.Label lblghichu;
        private System.Windows.Forms.TextBox txtmakhoa;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbthongtin;
        private System.Windows.Forms.GroupBox grbdanhsach;
        private System.Windows.Forms.DataGridView dvgdanhsach;
        private System.Windows.Forms.GroupBox grbchucnang;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ComboBox cbxkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}