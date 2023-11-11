namespace bai5._3_6
{
    public partial class Form1 : Form
    {
        int rowindex = -1;
        string[] listkhoa = { "Áo nam", "Áo nữ" };
        string[] donvitinh = { "VND", "Dolar" };
        public Form1()
        {
            InitializeComponent();
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

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowindex == -1 || rowindex >= dvgdanhsach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn SP cần xóa");
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