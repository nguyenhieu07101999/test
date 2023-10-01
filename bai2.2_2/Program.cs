using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static bai2._2_2.Sinhvien2;

namespace bai2._2_2
{

    internal class Program
    {

        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            List<sinhvien> listsinhvien = NhapDSSinhVien();
            XuatDSSV(listsinhvien);
            DSSVCNTT(listsinhvien);
            DSSVLONHON5(listsinhvien);


        }
        private static List<sinhvien> NhapDSSinhVien()
        {
            List<sinhvien> listsinhvien = new List<sinhvien>();
            Console.Write(" Nhap tong so SV n= :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Nhap DSSV");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n Nhap SV thu {0}:", i + 1);
                sinhvien sv = new sinhvien();
                sv.NhapSV(sv);
                listsinhvien.Add(sv);
            }
        }
        private static void XuatDSSV(List<sinhvien> listsinhvien)
        {
            Console.WriteLine("\n Xuat DSSV");
            foreach (sinhvien sv in listsinhvien)
            {
                sv.XuatSV();
            }
        }
        private static void DSSVCNTT(List<sinhvien> listsinhvien)
        {
            List<sinhvien> listCNTT1 = listsinhvien.Where(p => p._Khoa == "CNTT").ToList();
            List<sinhvien> listCNTT2 = (from s in listsinhvien where s._Khoa == "CNTT" select s).ToList();
            if (listCNTT1.Count == 0)
            {
                Console.WriteLine("Khong co SV khoa CNTT");
            }
            else
            {
                XuatDSSV(listCNTT1);
            }
            if (listCNTT2.Count == 0)
            {
                Console.WriteLine("Khong co SV khoa CNTT");
            }
            else
            {
                XuatDSSV(listCNTT2);

            }
        }
        private static void DSSVLONHON5(List<sinhvien> listsinhvien)
        {
            List<sinhvien> sinhviens = listsinhvien.Where(p => p._DiemTB >= 5).ToList();
            if (listsinhvien.Count == 0)
            {
                Console.WriteLine("Khong co SV diem >=5");
            }
            else
            {
                XuatDSSV(listsinhvien);
            }
        }
        private static void DSSVSAPXEP(List<sinhvien> listsinhvien)
        {
            List<sinhvien> listCNTT1 = listsinhvien.OrderBy(p => p._DiemTB).ToList();
            XuatDSSV(listsinhvien);
        }



    }

}
