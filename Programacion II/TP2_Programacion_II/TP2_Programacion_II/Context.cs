using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Programacion_II
{
    public class Context
    {
        private string connectionString;
        SqlConnection context;
        SqlCommand cmd;
        
        public Context()
        {
            connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TPII_PROGRAMACION_II;Integrated Security=True";
            context = new SqlConnection(connectionString);
            cmd = new SqlCommand();
           
        }

        public DataTable GetFromDatabase(string query)
        {
            context.Open();
            cmd.CommandText = query;
            cmd.Connection = context;
            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader());
            context.Close();
            return table;

        }

        public int PostToDatabase(string query, List<Parameter> valuesToInsert)
        {
            int rowAffecteds = 0;
            context.Open();
            cmd.Connection = context;
            cmd.CommandText = query;

            foreach (Parameter valuesToAdd in valuesToInsert)
            {
                cmd.Parameters.AddWithValue(valuesToAdd.Name, valuesToAdd.Value);
            }

            rowAffecteds = cmd.ExecuteNonQuery();

            return rowAffecteds;
            
        }

    }
}
