using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btncong_Click(object sender, EventArgs e)
        {
            try {
                double a, b;
                if (!double.TryParse(txtsoA.Text, out a))
                {
                    throw new Exception(" Số A không đc để trống và phải là số");
                }
                if (!double.TryParse(txtsoB.Text, out b))
                {
                    throw new Exception(" Số B không đc để trống và phải là số");
                }
                txtketqua.Text = (a + b).ToString();
            }
            catch (Exception ex) {
                txtketqua.Text=ex.Message;
            }
            
        }
        private void btntru_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtsoA.Text, out a))
                {
                    throw new Exception(" Số A không đc để trống và phải là số");
                }
                if (!double.TryParse(txtsoB.Text, out b))
                {
                    throw new Exception(" Số B không đc để trống và phải là số");
                }
                txtketqua.Text = (a - b).ToString();
            }
            catch (Exception ex)
            {
                txtketqua.Text = ex.Message;
            }

        }
        private void btnnhan_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtsoA.Text, out a))
                {
                    throw new Exception(" Số A không đc để trống và phải là số");
                }
                if (!double.TryParse(txtsoB.Text, out b))
                {
                    throw new Exception(" Số B không đc để trống và phải là số");
                }
                txtketqua.Text = (a * b).ToString();
            }
            catch (Exception ex)
            {
                txtketqua.Text = ex.Message;
            }

        }
        private void btnchia_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtsoA.Text, out a))
                {
                    throw new Exception(" Số A không đc để trống và phải là số");
                }
                if (!double.TryParse(txtsoB.Text, out b))
                {
                    throw new Exception(" Số B không đc để trống và phải là số");
                }
                txtketqua.Text = (a / b).ToString();
            }
            catch (Exception ex)
            {
                txtketqua.Text = ex.Message;
            }

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtketqua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
