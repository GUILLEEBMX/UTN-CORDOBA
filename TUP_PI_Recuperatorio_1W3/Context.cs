using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUP_PI_Recuperatorio_1W3
{
    class Context
    {
        private string connectionString;
        SqlConnection context;
        DataTable table;
        SqlCommand cmd;

        public Context()
        {
            connectionString = "Data Source=138.99.7.66,1433;Initial Catalog=Familia;User ID=tup1_familia;Password=5@Tup1";
            context = new SqlConnection(connectionString);
            cmd = new SqlCommand();

        }

        public DataTable GetFromSQL(string query)
        {
            table = new DataTable();
            cmd.CommandText = query;
            cmd.Connection = context;
            context.Open();
            table.Load(cmd.ExecuteReader());
            context.Close();
            return table;
        }

        public int PostToSQL(List<Parametro> valuesToInsert , string query)
        {
            int rowAffecteds = 0;

            cmd.CommandText = query;
            cmd.Connection = context;
            context.Open();

            foreach (Parametro values in valuesToInsert)
            {
                cmd.Parameters.AddWithValue(values.Name, values.Values);

            }

            rowAffecteds = cmd.ExecuteNonQuery();


            context.Close();


            return rowAffecteds;

        }



    }
}
