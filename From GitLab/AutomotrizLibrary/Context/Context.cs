using AutomotrizLibrary.Context;
using AutomotrizLibrary.Domain;
using AutomotrizLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;

namespace AutomotrizLibrary.Context
{
    public class Context
    {
        private static Context instance;
        private static SqlConnection context;
        private string connectionString = Properties.Resources.connectionString;
        SqlCommand cmd;
        DataTable table;


        private Context()
        {
            connectionString = Properties.Resources.connectionString;
            context = new SqlConnection(connectionString);

        }



        public static Context GetConnection()
        {
            if (instance == null)
            {
                instance = new Context();
            }
            return instance;
        }

        public static SqlConnection Connection()
        {
            if (context == null)
            {
                context = new SqlConnection(instance.connectionString);

            }

            return context;
        }


        public DataTable GetFromDataBase(string procedureName)
        {
            try
            {

                context.Open();
                cmd = new SqlCommand(procedureName, context);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = context;
                table = new DataTable();
                table.Load(cmd.ExecuteReader());
                cmd.Dispose();
                context.Close();
                return table;


            }
            catch (Exception ex)
            {


            }
            finally
            {
                if (context != null && context.State == ConnectionState.Open)
                    context.Close();

            }


            return table;
        }




    }
}
