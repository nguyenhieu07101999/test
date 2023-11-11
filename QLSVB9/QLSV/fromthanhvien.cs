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
    public partial class fromthanhvien : Form
    {
        public fromthanhvien()
        {
            InitializeComponent();
        }

        private ThanhVienDAO GetThanhVienDAO(ThanhVienDAO tvdao)
        {
            return tvdao;
        }

        private void fromthanhvien_Load(object sender, EventArgs e, ThanhVienDAO thanhVienDAO)
        {
            dvgdanhsach.DataSource = ThanhVienDAO.getList();
            txttongthanhvien.Text = thanhVienDAO.getCount().ToString();
        }
    }
}
