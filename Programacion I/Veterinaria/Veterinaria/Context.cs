using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class Context
    {

        private string connectionString;
        SqlConnection context;
        SqlCommand cmd;
        DataTable table;


        public Context()
        {
            connectionString = @"Data Source = .\SQLEXPRESS; Initial Catalog = VETERINARIA; Integrated Security = True"; 
            context = new SqlConnection(connectionString);    
        }

        public DataTable LeerBD(string query)
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

        public int GrabarBD (string query, List<Parametro> values)
        {
            int rowAffecteds = 0;

            context.Open();
            cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = context;

            //Parametro param = new Parametro();
            foreach (Parametro param in values)
            {
                cmd.Parameters.AddWithValue(param.Name, param.Value);
              
            }

            rowAffecteds = cmd.ExecuteNonQuery();

            context.Close();

            return rowAffecteds;
        }

        public int [] PrimaryKeyValues ()
        {
            table = LeerBD("SELECT * FROM MASCOTAS");

            int[] primaryKeyValues = new int[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
                primaryKeyValues[i] = (int)table.Rows[i].ItemArray[0];

            }

            return primaryKeyValues;

        }














        

        




    }
}
