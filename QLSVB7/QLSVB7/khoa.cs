using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSVB7
{
    internal class khoa
    {
        public string MaKhoa {  get; set; }
        public string TenKhoa { get; set; }
        public string GhiChu { get; set; }
        public khoa() { }
        public  khoa(string makhoa, string tenkhoa, string ghichu)
        {
            this.MaKhoa = makhoa;
            this.TenKhoa = tenkhoa;
            this.GhiChu = ghichu;

        }

    }
}
