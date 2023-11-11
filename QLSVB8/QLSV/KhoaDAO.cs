using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QLSV
{
    internal class KhoaDAO
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter apt = null;
        KetNoi KetNoi = new KetNoi();
        public  DataTable getList()
        {
            conn = KetNoi.GetConnection();
            string sql = "SELECT*FROM Khoa";
            cmd=new SqlCommand(sql, conn);
            apt=new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            apt.Fill(dt);
            return dt;
        }
    }
}
