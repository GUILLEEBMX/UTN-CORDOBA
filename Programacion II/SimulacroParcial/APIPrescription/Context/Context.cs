using APIPrescription.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIPrescription.Context
{
    public class Context
    {
        private static Context instance;
        private string connectionString;
        SqlConnection context;
        SqlCommand cmd;
        DataTable table;
        
        public Context()
        {
            connectionString = Properties.Resources.connectionString;
            context = new SqlConnection(connectionString);
        }

        public static Context GetInstance()
        {
            if (instance == null)
            {
                instance = new Context();
            }
            return instance;
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
                context.Close();
                return table;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                if (context != null && context.State == ConnectionState.Open)
                    context.Close();

            }


            return table;
        }

        public int PostToDataBase(Prescription prescription)
        {
            SqlTransaction transaction = null;
            int rowAffecteds = 0;
            int prescriptionId = 3;

            try
            {

                context.Open();
                transaction = context.BeginTransaction();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_INSERTAR_RECETA";
                cmd.Connection = context;
                cmd.Transaction = transaction;
                cmd.Parameters.AddWithValue("@ID_RECETA", prescriptionId);
                cmd.Parameters.AddWithValue("@NOMBRE", prescription.Nombre);
                cmd.Parameters.AddWithValue("@CHEFF", prescription.Cheff);
                cmd.Parameters.AddWithValue("@ID_TIPO_RECETA", 1);
                rowAffecteds = cmd.ExecuteNonQuery();
                //SqlParameter parameterOut = new SqlParameter("@id_receta", SqlDbType.Int);
                //parameterOut.Direction = ParameterDirection.Output;
                //cmd.Parameters.Add(parameterOut);
                //prescriptionId = (int)parameterOut.Value;




                for (int i = 0; i < prescription.PrescriptionDetails.Count; i++)
                {
                    SqlCommand _cmd = new SqlCommand();
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.CommandText = "SP_INSERTAR_DETALLE ";
                    _cmd.Connection = context;
                    _cmd.Transaction = transaction;
                    _cmd.Parameters.AddWithValue("@ID_RECETA", prescriptionId);
                    _cmd.Parameters.AddWithValue("@ID_INGREDIENTE", 1);
                    _cmd.Parameters.AddWithValue("@CANTIDAD", prescription.PrescriptionDetails[i].Amount);
                    rowAffecteds = _cmd.ExecuteNonQuery();


                }



                transaction.Commit();
                context.Close();

            }
            catch (Exception ex)
            {
                rowAffecteds = 0;
                if (transaction != null)
                {

                    transaction.Rollback();
                }
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                if (context != null && context.State == ConnectionState.Open)
                    context.Close();

            }

            return rowAffecteds;

        }







    }
}
