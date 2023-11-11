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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static ThanhVien thanhVien = null;
        //Kiểm tra đăng nhập

        private void Form1_Load(object sender, EventArgs e)
        {
            if (thanhVien == null)
            {
                frmDangNhap frm = new frmDangNhap();
                frm.ShowDialog();
               
            }
        }

        private void msmenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //tạo page
            TabPage tab=new TabPage();
            tab.Text = "Sinh Viên";
            tab.Name = "tbSinhVien";
            tab.ImageIndex = 1;
            //Tạo from và add tabpage trên atb;
            Form frm = new frmSinhVien();
            frm.TopLevel = false;
            frm.Parent = tab;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            tab.Controls.Add(frm);
            TabControl TabControlMain = null;
            // Kiểm tra tab đã tồn tại hay c
            if (!ExistTabPage(TabControlMain, "tbSinhVien"))
            {
                TabControlMain.TabPages.Add(tab);
            }
            TabControlMain.SelectedTab = TabControlMain.TabPages["tbSinhVien"];
        }
        private bool ExistTabPage (TabControl control,string tabPagename)
        {
            bool check=false;
            for(int i = 0;i < control.Controls.Count; i++)
            {
                if (control.TabPages[i].Name == tabPagename)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {

        }

        private void lblkhoa_Click(object sender, EventArgs e)
        {
            frmKhoa frm = new frmKhoa();
            frm.ShowDialog();
        }
       
    }
}
