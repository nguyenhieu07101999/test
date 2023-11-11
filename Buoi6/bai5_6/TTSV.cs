namespace bai5_6
{
    public partial class TTSV : Form
    {
        public TTSV()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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
        string[] danhsachkhoa = { "CNTT", "QTKD", "Kế toán", "Ngoại ngữ" };
        private int rowchoose;

        private void cbxkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtbngaysinh.MaxDate = DateTime.Now;
            loadKhoa();
        }
        private void loadKhoa()
        {
            cbxkhoa.DataSource = danhsachkhoa;
            cbxkhoa.SelectedItem = 0;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowchoose == -1 || rowchoose >= dvgdanhsach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn SV cần xóa");
                }
                dvgdanhsach.Rows.RemoveAt(rowchoose);
                rowchoose = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmasv.Text.Length != 10)
                {
                    throw new Exception("Mã SV phải đúng 1o kí tự");
                }
                if (txtmasv.Text.Length < 2)
                {
                    throw new Exception("Mã SV phải ít nhất 2 kí tự");
                }
                //Lấy thông tin
                string masv = txtmasv.Text;
                string hoten = txthoten.Text;
                string ngaysinh = dtbngaysinh.Text;
                string khoa = cbxkhoa.Text;
                //Lưu dữ liệu vào lưới
                int rowindex = dvgdanhsach.Rows.Add();//add tạo mới 1 hàng,trả về thêm
                dvgdanhsach.Rows[rowindex].Cells["MaSV"].Value = masv;
                dvgdanhsach.Rows[rowindex].Cells["HoTen"].Value = hoten;
                dvgdanhsach.Rows[rowindex].Cells["NgaySinh"].Value = ngaysinh;
                dvgdanhsach.Rows[rowindex].Cells["Khoa"].Value = khoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void dvgdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1 || e.RowIndex >= dvgdanhsach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên");
                }
                int rowchoose = dvgdanhsach.Rows.Add();
                txtmasv.Text = dvgdanhsach.Rows[rowchoose].Cells["MaSV"].Value.ToString();
                txthoten.Text = dvgdanhsach.Rows[rowchoose].Cells["HoTen"].Value.ToString();
                dtbngaysinh.Text = dvgdanhsach.Rows[rowchoose].Cells["NgaySinh"].Value.ToString();
                cbxkhoa.Text = dvgdanhsach.Rows[rowchoose].Cells["Khoa"].Value.ToString();
                btncapnhat.Enabled = true;
                btnxoa.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e, int rowchoose)
        {
            try
            {
                if (rowchoose == -1 || rowchoose >= dvgdanhsach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn SV cần cập nhật");
                }
                if (txtmasv.Text.Length != 10)
                {
                    throw new Exception("Mã SV phải ít nhất 2 kí tự");
                }
                //Lấy thông tin
                string masv = txtmasv.Text;
                string hoten = txthoten.Text;
                string ngaysinh = dtbngaysinh.Text;
                string khoa = cbxkhoa.Text;
                //Lưu dữ liệu vào lưới

                dvgdanhsach.Rows[rowchoose].Cells["MaSV"].Value = masv;
                dvgdanhsach.Rows[rowchoose].Cells["HoTen"].Value = hoten;
                dvgdanhsach.Rows[rowchoose].Cells["NgaySinh"].Value = ngaysinh;
                dvgdanhsach.Rows[rowchoose].Cells["Khoa"].Value = khoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}