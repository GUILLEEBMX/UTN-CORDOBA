using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.Context
{
    class Context
    {

        private static Context instance;
        private SqlConnection context;
        SqlCommand cmd;

        public Context()
        {

            context = new SqlConnection(Properties.Resources.connectionString);

        }


        public static Context GetInstance()
        {
            if (instance == null)
                instance = new Context();
            return instance;
        }


        public DataTable GetFromDataBase(string procedureName)
        {
            context.Open();
            cmd = new SqlCommand(procedureName, context);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            context.Close();
            return tabla;
        }



        public int PostToDataBase(string procedureName, Prescription prescription)
        {
            int rowAffecteds = 0;
            SqlTransaction transaction = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
                context.Open();
                transaction = context.BeginTransaction();
                cmd.Connection = context;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedureName;
                cmd.Transaction = transaction;
                cmd.Parameters.AddWithValue("@nombre", prescription.Name); 
                cmd.Parameters.AddWithValue("@tipo_receta", prescription.PrescriptionType); 
                cmd.Parameters.AddWithValue("@cheff", prescription.Cheff); 
                rowAffecteds = cmd.ExecuteNonQuery();
                SqlParameter parameter = new SqlParameter("@id_receta", SqlDbType.Int);
                parameter.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parameter);
                int prescriptionNumber = Convert.ToInt32(parameter.Value);

                foreach (DetailPrescription detailPrescription in prescription.DetailPrescription)
                {
                    SqlCommand _cmd = new SqlCommand("SP_INSERTAR_DETALLES",context);
                    _cmd.Transaction = transaction;
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.Parameters.AddWithValue("@id_receta", prescriptionNumber);
                    _cmd.Parameters.AddWithValue("@id_ingrediente", detailPrescription.Ingredient.IngredientId);
                    _cmd.Parameters.AddWithValue("@cantidad", detailPrescription.Amount);
                    _cmd.ExecuteNonQuery();

                }


                transaction.Commit();
            }
            catch (SqlException)
            {
                if (transaction != null) { transaction.Rollback(); }
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
