
using System.Data;
using System.Data.SqlClient;

using TP2_Programacion_II.Services;

namespace TP2_Programacion_II
{
    public class Context 
    {
        private string connectionString;
        SqlConnection context;
       
        public Context()
        {
            connectionString = Properties.Resources.connectionString;
            context = new SqlConnection(connectionString);
        }

        public SqlConnection Connection()
        {
             return context = new SqlConnection(connectionString);
        }

        public void Open()
        {
            context.Open();
        }
        public void Close()
        {
            context.Close();
        }



    }






}







