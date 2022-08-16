using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Programacion_II
{
    class Context
    {
        private string connectionString;
        SqlConnection context;
        SqlCommand cmd;
      

        public Context()
        {

            connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TP1_PROGRAMACION_II;Integrated Security=True";
            context = new SqlConnection(connectionString);
            cmd = new SqlCommand();
           
        }


        public DataTable GetFromDataBase(string query)
        {
            
            context.Open();
            cmd.CommandText = query;
            cmd.Connection = context;
            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader());
            context.Close();
            return table;

        }

        public int PostToDatabase(string query,List<Parameter> valuesToInsert)
        {
            int rowAffecteds = 0;
            context.Open();
            cmd.CommandText = query;
            cmd.Connection = context;

            foreach (Parameter valuesToadd in valuesToInsert)
            {
                cmd.Parameters.AddWithValue(valuesToadd.Name,valuesToadd.Value);

            }


            rowAffecteds = cmd.ExecuteNonQuery();

            context.Close();


            return rowAffecteds;

        }




    }
}
