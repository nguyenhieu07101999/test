using QLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
   
    public partial class Form1 : Form
    {
        SinhVienDao svDAO = new SinhVienDao();
        KhoaDAO khoDAO = new KhoaDAO();
        string insertupdate = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnluu.Enabled = true;
            txtmasv.Enabled = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnluu.Enabled = true;
            txtmasv.Enabled = false;
        }

        private void dvgdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dvgdanhsach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên");
                }
                txtmasv.Text = dvgdanhsach.Rows[rowindex].Cells["MaSV"].Value.ToString();
                txthoten.Text = dvgdanhsach.Rows[rowindex].Cells["HoTen"].Value.ToString();
                cbxkhoa.Text = dvgdanhsach.Rows[rowindex].Cells["TenKhoa"].Value.ToString();
                txtdiemtb.Text = dvgdanhsach.Rows[rowindex].Cells["DiemTB"].Value.ToString();
                btnxoa.Enabled=true;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message,"Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

