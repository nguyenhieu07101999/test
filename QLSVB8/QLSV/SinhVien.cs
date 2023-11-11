using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    internal class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public int MaKhoa { get; set; }
        public double DiemTB { get; set; }
        public SinhVien() { }
        public SinhVien(string maSV, string hoTen, int maKhoa, double diemTB)
        {
            this.MaSV = maSV;
            this.HoTen = hoTen;
            this.MaKhoa = maKhoa;
            this.DiemTB = diemTB;
        }
    }
}
