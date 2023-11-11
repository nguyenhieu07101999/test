using System.Security.Cryptography.X509Certificates;

namespace bai5._2_6
{
    public partial class QLSV : Form
    {
        int rowindex = -1;
        string[] listkhoa = { "Công nghệ thông tin", "Kế toán", " Ngoại ngữ", " Điện tử" };
        public QLSV()
        {
            InitializeComponent();
        }
        private void QLSV_Load(object sender, EventArgs e)
        {
            cbxkhoa.DataSource = listkhoa;
        }

        private void cbxkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không!", "Xác nhận",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question!);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                double diemtb;
                if (!txtmasv.Text.Length.Equals(10))
                {
                    throw new Exception("Mã SV phải đúng 1o kí tự");
                }
                if (this.checkmasv(txtmasv.Text) == false)
                {
                    throw new Exception("Mã SV phải đã tồn tại");
                }

                if (txthoten.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên không đc để trống!");
                }

                if (!double.TryParse(txtdiemtb.Text, out diemtb))
                {
                    throw new Exception("Điểm TB không phải số");
                }
                //Lấy thông tin
                string masv = txtmasv.Text;
                string hoten = txthoten.Text;
                string khoa = cbxkhoa.Text;
                //Lưu dữ liệu vào lưới
                int rowindex = dvgdanhsach.Rows.Add();//add tạo mới 1 hàng,trả về thêm
                dvgdanhsach.Rows[rowindex].Cells["MaSV"].Value = masv;
                dvgdanhsach.Rows[rowindex].Cells["HoTen"].Value = hoten;
                dvgdanhsach.Rows[rowindex].Cells["DiemTB"].Value = diemtb;
                dvgdanhsach.Rows[rowindex].Cells["Khoa"].Value = khoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public bool checkmasv(string masv)
        {
            if (dvgdanhsach.Rows.Count == 0)
            {
                return true;
            }
            for (int row = 0; row < dvgdanhsach.Rows.Count - 1; row++)
            {
                if (dvgdanhsach.Rows[row].Cells["MaSV"].Value.ToString() == masv)
                    return false;
            }
            return true;
        }

        private void dvgdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            if (rowindex != -1 && rowindex < dvgdanhsach.Rows.Count - 1)
            {

                txtmasv.Text = dvgdanhsach.Rows[rowindex].Cells["MaSV"].Value.ToString();
                txthoten.Text = dvgdanhsach.Rows[rowindex].Cells["Hoten"].Value.ToString();
                txtdiemtb.Text = dvgdanhsach.Rows[rowindex].Cells["DiemTB"].Value.ToString();
                string tenkhoa = dvgdanhsach.Rows[rowindex].Cells["Khoa"].Value.ToString();
                int i = 0;
                while (i < listkhoa.Length && listkhoa[i] != tenkhoa)
                {
                    i++;
                }
                cbxkhoa.SelectedIndex = i;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            double diemtb;
            try
            {
                if (rowindex == -1 || rowindex >= dvgdanhsach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn SV cần xóa");
                }
                if (!txtmasv.Text.Length.Equals(10))
                {
                    throw new Exception("Mã SV 10 ký tự");
                }
                if (this.checkmasv(txtmasv.Text) == false && txtmasv.Text != dvgdanhsach.Rows[rowindex].Cells["MaSV"].Value.ToString())
                {
                    throw new Exception("Mã SV đã tồn tại");
                }
                if (txtmasv.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên không đc để trống");
                }
                if (!double.TryParse(txtdiemtb.Text, out diemtb))
                {
                    throw new Exception("Điểm TB k phải số");
                }
                //Lấy thông tin
                string masv = txtmasv.Text;
                string hoten = txthoten.Text;
                string khoa = cbxkhoa.Text;
                //Lưu dữ liệu vào lưới

                dvgdanhsach.Rows[rowindex].Cells["MaSV"].Value = masv;
                dvgdanhsach.Rows[rowindex].Cells["HoTen"].Value = hoten;
                dvgdanhsach.Rows[rowindex].Cells["DiemTB"].Value = diemtb;
                dvgdanhsach.Rows[rowindex].Cells["Khoa"].Value = khoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowindex == -1 || rowindex >= dvgdanhsach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn SV cần xóa");
                }
                dvgdanhsach.Rows.RemoveAt(rowindex);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
}