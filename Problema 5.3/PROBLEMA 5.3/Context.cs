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
        //DataTable table;

        public Context ()
        {
            connectionString = @"Data Source = .\SQLEXPRESS; Initial Catalog = PRODUCTOS_PROBLEMA_5_3; Integrated Security = True";
            context  = new SqlConnection(connectionString);
            cmd = new SqlCommand();
        }

        public DataTable GetFromSQL(string query)
        {
            context.Open();
            cmd.CommandText = query;
            cmd.Connection = context;
            DataTable table;
            table = new DataTable();
            table.Load(cmd.ExecuteReader());
            context.Close();
            return table;
        }

        public int  PostToSQL(string query, List<Parametro> valuesToInsert)
        {
            int rowAffecteds = 0;

            context.Open();
            cmd.CommandText = query;
            cmd.Connection = context;

            foreach (Parametro values in valuesToInsert)
            {
                cmd.Parameters.AddWithValue(values.Nombre, values.Valor);
            }

            rowAffecteds = cmd.ExecuteNonQuery();

            context.Close();

            return rowAffecteds;
         
        }

        public int DeleteFromDB(int id,string tableName)
        {
            int rowAffecteds = 0;

            context.Open();
            cmd.CommandText = "DELETE FROM " + tableName + " " + "WHERE codigo = " + id;
            cmd.Connection = context;
      
            rowAffecteds =  cmd.ExecuteNonQuery();

            context.Close();

            return rowAffecteds;
            
        }

        public int[] PrimaryKeyValues()
        {
            DataTable table = new DataTable();
            table = GetFromSQL("SELECT * FROM Productos");

            int[] primaryKeys = new int[table.Rows.Count];

            for (int i = 0; i < primaryKeys.Length; i++)
            {
                primaryKeys[i] = (int)table.Rows[i].ItemArray[0];

            }

            return primaryKeys;

        }
















    }
}
