﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    internal class KetNoi
    {
        string sqlConnect;
        public KetNoi() { 
            sqlConnect = ConfigurationManager.ConnectionStrings["ChuoiKN"].ToString();

        }public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(sqlConnect);
            return conn;
        }
    }
}
