using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2_2
{
    internal class sinhvien
    {
        public string _MaSV  {  get; set; }
        public string _HoTen { get; set; }
        public double _DiemTB { get; set; }
        public string _Khoa {  get; set; }
        //khai bao construct
        // Dang k tham so
        public sinhvien() { }
        public sinhvien(string ma,string hoten,double diemtb,string khoa)
        {
            this._MaSV = ma;
            this._HoTen = hoten;
            this._DiemTB = diemtb;
            this._Khoa = khoa;
            
        }
        public sinhvien(sinhvien sv)
        {
            this._MaSV = sv._MaSV;
            this._HoTen = sv._HoTen;
            this._DiemTB = sv._DiemTB;
            this._Khoa = sv._Khoa;

        }
        public void NhapSV()
        {
            Console.Write("Nhap SV:");
            _MaSV = Console.ReadLine();
            Console.Write("Nhap Ho ten:");
            _HoTen = Console.ReadLine();
            Console.Write("Nhap DiemTb:");
            _DiemTB=double.Parse(Console.ReadLine());
            Console.Write("Nhap khoa:");
            _Khoa=Console.ReadLine();
        }
        //xuat sv
        public void XuatSV()
        {
            Console.WriteLine("MaSV:{0} \t Hoten:{1} \t DiemTB {2} \t Khoa{3}", _MaSV, _HoTen, _DiemTB, _Khoa);
        }

    }
    
}
