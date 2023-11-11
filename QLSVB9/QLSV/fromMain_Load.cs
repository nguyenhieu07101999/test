using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btndnhap_Click(object sender, EventArgs e)
        {
            string username= txtuser.Text.Trim();
            string password= txtpassword.Text.Trim();
            ThanhVienDAO thanhVienDAO = new ThanhVienDAO();
            ThanhVien tv = thanhVienDAO.getRow(username);
            if(tv == null) {
                lblthongbao.Text = "tài khoản đã tồn tại";
            }
            else
            {
                if(tv.MatKhau==password) {
                    Form1.thanhVien=tv;
                    this.Close();
                }
                else
                {
                    lblthongbao.Text = "Mật khẩu không chính xác";
                }
            }
        }
        public static class MaHoa
        {
            public static string ToMD5(string str)
            {
                MD5 mh = MD5.Create();
                byte[] intputBytes=System.Text.Encoding.ASCII.GetBytes(str);
                byte[] hash=mh.ComputeHash(intputBytes);
                StringBuilder chuoimahoa=new StringBuilder();
                for(int i = 0;i< hash.Length; i++)
                {
                    chuoimahoa.Append(hash[i].ToString("X2"));
                }
                return chuoimahoa.ToString();
            }
        }
        // Thoát user
        private void btnthoat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
