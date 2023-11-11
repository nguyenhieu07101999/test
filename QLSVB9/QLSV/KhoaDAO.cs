using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    internal class KhoaDAO
    {
        QLSVDbContext db = new QLSVDbContext();

        internal static void deleteTwo(int makhoa)
        {
            throw new NotImplementedException();
        }

        internal static void deleteTwo(string makhoa)
        {
            throw new NotImplementedException();
        }

        public List<Khoa> getList()
        {
            List<Khoa> list = db.Khoas.ToList();
            return list;
        }

        public Khoa getRow(int makhoa) { 
            Khoa k= db.Khoas.Where(m=>m.MaKhoa==makhoa).First();
            return k;
        }
    }
}
