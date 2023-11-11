using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    internal class ThanhVienDAO
    {
        QLSVDbContext db = new QLSVDbContext();
        //lấy ra all thanhvien
        public List<ThanhVien> getlist()
        {
            List<ThanhVien> list = db.ThanhViens.ToList();
            return list;
        }

        //lấy ra 1  thanhvien 

        public ThanhVien getOne(string tendn,string mk)
        {
            ThanhVien tv = db.ThanhViens.Where(m => m.TenDangNhap == tendn && m.MatKhau==mk).First();
            return tv;
        }
        //lấy ra sl thanhvien
        public int getCount()
        {
            return db.ThanhViens.Count();
        }
        //Thêm
        public void Insert(ThanhVien tv)
        {
            db.ThanhViens.Add(tv);
            db.SaveChanges();
        }
        //Sửa
        public void Update(ThanhVien tv)
        {
            db.Entry(tv).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        //Xóa
        public void Delete(ThanhVien tv)
        {
            db.ThanhViens.Remove(tv);
            db.SaveChanges();
        }

        internal ThanhVien getRow(string username)
        {
            throw new NotImplementedException();
        }

        internal static object getList()
        {
            throw new NotImplementedException();
        }
    }
}
