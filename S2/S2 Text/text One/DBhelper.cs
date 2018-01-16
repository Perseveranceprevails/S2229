using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_One
{
    class DBhelper
    {
        private SqlConnection con;
        public SqlConnection Con 
        {
            get 
            {
                string sql = "Data Source=.;Initial Catalog=BoardroomManager;User ID=sa;Password=123";
                if(con==null)
                {
                    con = new SqlConnection(sql);
                }
                return con;
            }
        }
        public void OpenSql() 
        {
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            if(con.State==ConnectionState.Broken)
            {
                con.Close();
                con.Open();
            }
        }
        public void CloseSql() 
        {
            if(con.State==ConnectionState.Open || con.State==ConnectionState.Broken)
            {
                con.Close();
            }
        }
    }
}
