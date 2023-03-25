using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Functions
    {

        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string conStr;

        public Functions()
        {
            conStr = @"Data Source=localhost;Initial Catalog=esports_new;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True;Application Name=EntityFramework";
            con = new SqlConnection(conStr);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        public DataTable getData(string Query) 
            {
                dt = new DataTable();
                sda = new SqlDataAdapter(Query, conStr);
                sda.Fill(dt);
                return dt;
            }

        public int setData(string Query1)
            {
                int cnt = 0;
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.CommandText = Query1;
                cnt = cmd.ExecuteNonQuery();
                con.Close();
                return cnt;
            }

  


    }

   
} 
        
    
