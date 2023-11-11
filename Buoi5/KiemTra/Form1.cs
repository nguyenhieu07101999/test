using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void grbchucnang_Enter(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e, int rowchoose)
        {
            try
            {
                if (rowchoose == -1 || rowchoose >= dvgsinhvien.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên cần xóa");
                }
                dvgsinhvien.Rows.RemoveAt(rowchoose);
                rowchoose = -1;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnsvm_Click(object sender, EventArgs e)
        {
            
            try {
                if (txtmasv.Text.Length != 10)
                {
                    throw new Exception("Mã sinh viên phải đúng 10 kí tự");
                }
                if (txthoten.Text.Equals(0))
                {
                    throw new Exception("Họ tên không được để trống");
                }
                string masv=txtmasv.Text;
                string hoten=txthoten.Text;
                string diemquatrinh=txtdiemquatrinh.Text;
                string diemthi=txtdiemthi.Text;
                //
                
                int rowindex=dvgsinhvien.Rows.Add();
                dvgsinhvien.Rows[rowindex].Cells["MaSV"].Value=masv;
               
                dvgsinhvien.Rows[rowindex].Cells["HoTen"].Value = hoten;
              
                dvgsinhvien.Rows[rowindex].Cells["DiemQT"].Value = diemquatrinh;
               
                dvgsinhvien.Rows[rowindex].Cells["DiemThi"].Value = diemthi;
                btnsvm = new Button();

            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
           
                    }
        }
        private void dvgsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e, int rowchoose)
        {
            try
            {
                if (e.RowIndex==-1||e.RowIndex>=dvgsinhvien.Rows.Count-1)               {
                    throw new Exception("Chưa chọn sinh viên");
                }
                rowchoose = e.RowIndex;
                txtmasv.Text = dvgsinhvien.Rows[rowchoose].Cells["MaSV"].Value.ToString();
                txtmasv.Text = dvgsinhvien.Rows[rowchoose].Cells["HoTen"].Value.ToString();
                txtmasv.Text = dvgsinhvien.Rows[rowchoose].Cells["DiemQT"].Value.ToString();
                txtmasv.Text = dvgsinhvien.Rows[rowchoose].Cells["DiemThi"].Value.ToString();
                btnxoa.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dvgsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
