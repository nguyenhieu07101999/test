using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    internal class SinhVienDAO
    {
        QLSVDbContext db=new QLSVDbContext();
        //lấy ra all sinhvien
        public List<SinhVien> getlist() {
            List<SinhVien> list =db.SinhViens.ToList();
            return list;
        }
        
        //lấy ra 1  sinhvien 

        public SinhVien getOne(string masv) {
            SinhVien sv= db.SinhViens.Where(m=>m.MaSV==masv).First();
            return sv;
        }
        //lấy ra sl sinhvien
        public int getCount()
        {
            return db.SinhViens.Count();
        }
        //Thêm
        public void Insert(SinhVien sv)
        {
            db.SinhViens.Add(sv);
            db.SaveChanges();
        }
        //Sửa
        public void Update(SinhVien sv)
        {
            db.Entry(sv).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges() ;
        }
        //Xóa
        public void Delete(SinhVien sv)
        {
            db.SinhViens.Remove(sv);
            db.SaveChanges() ;
        }

    }
}
