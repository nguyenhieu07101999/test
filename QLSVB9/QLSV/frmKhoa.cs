using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frmKhoa : Form
    {
        KhoaDAO khoaD = new KhoaDAO();
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không ?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string inserupdate = "insert";
            btnluu.Enabled = true;
            txtmakhoa.Enabled = true;
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            loadDSKhoa();
        }
        private void loadDSKhoa()
        {
            cbxkhoa.DataSource = khoaD.getList();
            cbxkhoa.DisplayMember = "TenKhoa";
            cbxkhoa.ValueMember = "MaKhoa";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string insertupdate = "update";
            btnluu.Enabled=true;
            txtmakhoa.Enabled=false;
        }

        private void dvgdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                int rowindex = e.RowIndex;
                if(rowindex == -1|| rowindex >=dvgdanhsach.Rows.Count-1) {
                    throw new Exception("Chưa chọn khoa");
                }
                txtmakhoa.Text = dvgdanhsach.Rows[rowindex].Cells["MaKhoa"].Value.ToString();
                cbxkhoa.Text = dvgdanhsach.Rows[rowindex].Cells["TênKhoa"].Value.ToString();
                txtghichu.Text = dvgdanhsach.Rows[rowindex].Cells["GhiChu"].Value.ToString();
                btnxoa.Enabled = true;
            } catch (Exception ex) { 
                 MessageBox.Show(ex.Message,"Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnluu_Click(object sender, EventArgs e, int insertupdate)
        {
            try
            {
                if (txtmakhoa.Text.Length != 10)
                {
                    throw new Exception("Mã Khoa phải đúng 10 kí tự");
                }
                int makhoa =int.Parse(cbxkhoa.SelectedValue.ToString());
                string khoa=cbxkhoa.Text;
                string ghichu=txtghichu.Text;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmakhoa.Text.Length!=10)
                {
                    throw new Exception("Mã Khoa k đúng");
                }
                string makhoa = txtmakhoa.Text;
                KhoaDAO.deleteTwo(makhoa);
                loadDSKhoa();
                MessageBox.Show("Xóa thành công", "Thông báo");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmkhoa(object sender, EventArgs e)
        {
          
            dvgdanhsach.DataSource = khoaD.getList();
            txtmakhoa.Text = dvgdanhsach.ToString();
            cbxkhoa.Text = dvgdanhsach.ToString();
            txtghichu.Text = dvgdanhsach.ToString();
        }
    }
}
