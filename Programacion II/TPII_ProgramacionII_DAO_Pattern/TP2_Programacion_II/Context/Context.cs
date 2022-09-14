
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TP2_Programacion_II.Services;

namespace TP2_Programacion_II
{
    public class Context 
    {
        private static Context context;
        private string connectionString;
        private static SqlConnection connection;

        private Context()
        {
            connectionString = Properties.Resources.connectionString;
        }


        public static Context GetInstance()
        {
            if (context == null)
            {
                context = new Context();
            }
            return context;
        }


        public static SqlConnection Connection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(context.connectionString);

            }

            return connection;
        }



    }

}














