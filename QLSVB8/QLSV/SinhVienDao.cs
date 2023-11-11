using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace QLSV
{
    internal class SinhVienDao
    {
        SqlConnection conn=null;
        SqlCommand cmd=null;
        SqlDataAdapter apt=null;
        KetNoi KetNoi = new KetNoi();
        public SinhVienDao()
        {
            conn = KetNoi.GetConnection();
            if(conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
        }
    }
}
