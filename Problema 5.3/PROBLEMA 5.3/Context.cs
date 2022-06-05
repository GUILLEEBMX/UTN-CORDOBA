using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA_5._3
{
    class Context
    {
        private string connectionString;
        SqlConnection context;
        SqlCommand cmd;
        DataTable table;

        public Context ()
        {
            connectionString = @"Data Source = .\SQLEXPRESS; Initial Catalog = PRODUCTOS_PROBLEMA_5_3; Integrated Security = True";
            context  = new SqlConnection(connectionString);
        }

        public DataTable GetFromSQL(string query)
        {
            context.Open();
            cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = context;
            table = new DataTable();
            table.Load(cmd.ExecuteReader());
            context.Close();
            return table;
        }

        public int  PostToSQL(string query,Parametro values)
        {
            int rowAffecteds = 0;

     

        
            context.Open();
            cmd.CommandText = query;
            cmd.Connection = context;

            for (int i = 0; i < values.param.Length; i++)
            {
               var x =  values.param[i];




                
            }

            rowAffecteds = cmd.ExecuteNonQuery();

            return rowAffecteds;
         
            
         
            









        }
















    }
}
