using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhap tieng viet
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write(" Nhap tong so SV n= :");
            List<sinhvien> listsinhvien = new List<sinhvien>();
            int n = Convert.ToInt32(Console.ReadLine());
            sinhvien[] arrsinhvien = new sinhvien[n];
            Console.WriteLine("\n Nhap DSSV");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n Nhap SV thu {0}:", i + 1);
                arrsinhvien[i] = new sinhvien();
                arrsinhvien[i].NhapSV();
            }
            Console.WriteLine("\n Xuat DSSV");
            foreach (sinhvien sv in arrsinhvien)
            {
                sv.XuatSV();
            }
            Console.ReadKey();
            //Bai 2.2
            //Console.WriteLine("\n Nhap DSSV");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("\n Nhap SV thu {0}:", i + 1);
            //    sinhvien sv = new sinhvien();
            //    sv.NhapSV();
            //    listsinhvien.Add(sv);
            //}
            

            //Console.WriteLine("\n Xuat DSSV");
            //foreach (sinhvien sv in listsinhvien)
            //{
            //    sv.XuatSV();
            //}
            //Console.ReadKey();
        }
       
    }
}
