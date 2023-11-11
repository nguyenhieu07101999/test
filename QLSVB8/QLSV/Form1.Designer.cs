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
            this.grbthongtin = new System.Windows.Forms.GroupBox();
            this.grbchucnang = new System.Windows.Forms.GroupBox();
            this.grbdanhsach = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmasv = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lbldiemtb = new System.Windows.Forms.Label();
            this.lblkhoa = new System.Windows.Forms.Label();
            this.cbxkhoa = new System.Windows.Forms.ComboBox();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtdiemtb = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnloc = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.dvgdanhsach = new System.Windows.Forms.DataGridView();
            this.grbthongtin.SuspendLayout();
            this.grbchucnang.SuspendLayout();
            this.grbdanhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgdanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // grbthongtin
            // 
            this.grbthongtin.Controls.Add(this.txtdiemtb);
            this.grbthongtin.Controls.Add(this.txthoten);
            this.grbthongtin.Controls.Add(this.txtmasv);
            this.grbthongtin.Controls.Add(this.cbxkhoa);
            this.grbthongtin.Controls.Add(this.lblmasv);
            this.grbthongtin.Controls.Add(this.lblhoten);
            this.grbthongtin.Controls.Add(this.lbldiemtb);
            this.grbthongtin.Controls.Add(this.lblkhoa);
            this.grbthongtin.Location = new System.Drawing.Point(15, 64);
            this.grbthongtin.Name = "grbthongtin";
            this.grbthongtin.Size = new System.Drawing.Size(1236, 124);
            this.grbthongtin.TabIndex = 0;
            this.grbthongtin.TabStop = false;
            this.grbthongtin.Text = "Thông tin";
            // 
            // grbchucnang
            // 
            this.grbchucnang.Controls.Add(this.btnthoat);
            this.grbchucnang.Controls.Add(this.btnloc);
            this.grbchucnang.Controls.Add(this.btnsua);
            this.grbchucnang.Controls.Add(this.btnluu);
            this.grbchucnang.Controls.Add(this.btnxoa);
            this.grbchucnang.Controls.Add(this.btnthem);
            this.grbchucnang.Location = new System.Drawing.Point(15, 194);
            this.grbchucnang.Name = "grbchucnang";
            this.grbchucnang.Size = new System.Drawing.Size(1236, 89);
            this.grbchucnang.TabIndex = 1;
            this.grbchucnang.TabStop = false;
            this.grbchucnang.Text = "Chức năng";
            // 
            // grbdanhsach
            // 
            this.grbdanhsach.Controls.Add(this.dvgdanhsach);
            this.grbdanhsach.Location = new System.Drawing.Point(15, 310);
            this.grbdanhsach.Name = "grbdanhsach";
            this.grbdanhsach.Size = new System.Drawing.Size(1236, 270);
            this.grbdanhsach.TabIndex = 1;
            this.grbdanhsach.TabStop = false;
            this.grbdanhsach.Text = "Danh sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(425, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // lblmasv
            // 
            this.lblmasv.AutoSize = true;
            this.lblmasv.Location = new System.Drawing.Point(32, 33);
            this.lblmasv.Name = "lblmasv";
            this.lblmasv.Size = new System.Drawing.Size(47, 16);
            this.lblmasv.TabIndex = 3;
            this.lblmasv.Text = "Mã SV";
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(32, 81);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(52, 16);
            this.lblhoten.TabIndex = 4;
            this.lblhoten.Text = "Họ Tên";
            // 
            // lbldiemtb
            // 
            this.lbldiemtb.AutoSize = true;
            this.lbldiemtb.Location = new System.Drawing.Point(694, 81);
            this.lbldiemtb.Name = "lbldiemtb";
            this.lbldiemtb.Size = new System.Drawing.Size(59, 16);
            this.lbldiemtb.TabIndex = 5;
            this.lbldiemtb.Text = "Điểm TB";
            // 
            // lblkhoa
            // 
            this.lblkhoa.AutoSize = true;
            this.lblkhoa.Location = new System.Drawing.Point(694, 33);
            this.lblkhoa.Name = "lblkhoa";
            this.lblkhoa.Size = new System.Drawing.Size(38, 16);
            this.lblkhoa.TabIndex = 6;
            this.lblkhoa.Text = "Khoa";
            // 
            // cbxkhoa
            // 
            this.cbxkhoa.FormattingEnabled = true;
            this.cbxkhoa.Location = new System.Drawing.Point(755, 30);
            this.cbxkhoa.Name = "cbxkhoa";
            this.cbxkhoa.Size = new System.Drawing.Size(376, 24);
            this.cbxkhoa.TabIndex = 7;
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(101, 27);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(376, 22);
            this.txtmasv.TabIndex = 8;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(101, 81);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(376, 22);
            this.txthoten.TabIndex = 9;
            // 
            // txtdiemtb
            // 
            this.txtdiemtb.Location = new System.Drawing.Point(755, 81);
            this.txtdiemtb.Name = "txtdiemtb";
            this.txtdiemtb.Size = new System.Drawing.Size(376, 22);
            this.txtdiemtb.TabIndex = 10;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(18, 38);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(109, 24);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(697, 38);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(109, 24);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(464, 38);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(109, 24);
            this.btnluu.TabIndex = 2;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(235, 38);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(109, 24);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnloc
            // 
            this.btnloc.Location = new System.Drawing.Point(907, 38);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(109, 24);
            this.btnloc.TabIndex = 4;
            this.btnloc.Text = "Lọc";
            this.btnloc.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(1109, 38);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(109, 24);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // dvgdanhsach
            // 
            this.dvgdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgdanhsach.Location = new System.Drawing.Point(14, 30);
            this.dvgdanhsach.Name = "dvgdanhsach";
            this.dvgdanhsach.RowHeadersWidth = 51;
            this.dvgdanhsach.RowTemplate.Height = 24;
            this.dvgdanhsach.Size = new System.Drawing.Size(1203, 227);
            this.dvgdanhsach.TabIndex = 0;
            this.dvgdanhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgdanhsach_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 592);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbchucnang);
            this.Controls.Add(this.grbdanhsach);
            this.Controls.Add(this.grbthongtin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbthongtin.ResumeLayout(false);
            this.grbthongtin.PerformLayout();
            this.grbchucnang.ResumeLayout(false);
            this.grbdanhsach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgdanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbthongtin;
        private System.Windows.Forms.TextBox txtdiemtb;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.ComboBox cbxkhoa;
        private System.Windows.Forms.Label lblmasv;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lbldiemtb;
        private System.Windows.Forms.Label lblkhoa;
        private System.Windows.Forms.GroupBox grbchucnang;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnloc;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox grbdanhsach;
        private System.Windows.Forms.DataGridView dvgdanhsach;
        private System.Windows.Forms.Label label1;
    }
}

