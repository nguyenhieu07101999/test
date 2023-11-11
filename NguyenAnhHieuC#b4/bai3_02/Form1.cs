using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            try{
                if (txthoten.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên sinh viên k thể để trống");
                }
                //Lấy thông tin
                string hoten = txthoten.Text;
                string masv = txtmasv.Text;
                string ngaysinh=txtngáyinh.Text;
                string gioitinh = (rdbnam.Checked) ? "Nam" : "Nữ";
                string sothich = null;
                if(cbdulich.Checked)
                {
                    sothich += "Du Lịch";
                }
                if(cbthethao.Checked)
                {
                    sothich += "Thể Thao";
                }
                if(cbmuasam.Checked)
                {
                    sothich += "Mua Sắm";
                }
                if(sothich !=null)
                {
                    sothich = "Sở thích" + sothich;
                }
                // xuất thông tin ra danh sách
                string thongTinSV = $"Mã sinh viên: {masv}\nHọ tên: {hoten}\nNgày sinh: {ngaysinh}\nGiới tính: {gioitinh}\nSở thích: {sothich}\n";

                txtdanhsach.AppendText(thongTinSV + "\n");

            }
            
            catch(Exception ex) { 
               lblketqua.Text = ex.Message;
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtdanhsach.Text = "";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        
    }
}
