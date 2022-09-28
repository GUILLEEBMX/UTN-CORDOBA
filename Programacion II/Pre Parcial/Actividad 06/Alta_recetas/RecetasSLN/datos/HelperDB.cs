using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos
{
    class HelperDB
    {

        private static HelperDB instancia;
        private SqlConnection cnn;
        private string connectionString;
        SqlCommand cmd;

        public HelperDB()  // CUANDO ESTO SE CONSTRUYE TE DEVUELVE UNA CONEXION A SQL 
        {

            cnn = new SqlConnection(@"Data Source= .\SQLEXPRESS;Initial Catalog=RECETAS;Integrated Security=True");

        }


        public static HelperDB ObtenerInstancia() //ES COMO SI FUERA CONSTANTE PI = 3.14
        {
            if (instancia == null) //NO EXISTE NEW AUN OBJETO OBJETO1 == NULL ;
                instancia = new HelperDB(); // NEW OBJETO(); SI ES NULA
            return instancia; //SIEMPRE DEVUELVE CONEXION A LA BASE
        }


        public DataTable ConsultarSQL(string nombreProcedimiento)
        {
            cnn.Open();
            cmd = new SqlCommand(nombreProcedimiento, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla; //SE RETORNA EL SELECT * FROM NOMBRE TABLA
        }



        public int EjecutarSQL(string strSql, Receta receta)
        {
            int afectadas = 0;
            SqlTransaction t = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = strSql;
                cmd.Transaction = t;

                cmd.Parameters.AddWithValue("@nombre", receta.Nombre); //receta nombre
                cmd.Parameters.AddWithValue("@tipo_receta", receta.TipoReceta); //receta tipo receta
                cmd.Parameters.AddWithValue("@cheff", receta.Cheff); //receta cheff



                afectadas = cmd.ExecuteNonQuery();





                t.Commit(); //CONFIRMA QUE LA TRANSACCION SEA EXITOSA
            }
            catch (SqlException)
            {
                if (t != null) { t.Rollback(); }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }

            return afectadas;
        }


        public int InsertarDetalle(string SP, List<DetalleReceta> detalleReceta)
        {
            int afectadas = 0;
            SqlTransaction t = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SP;
                cmd.Transaction = t;

                for (int i = 0; i < detalleReceta.Count; i++)
                {
                    cmd.Parameters.AddWithValue("@id_receta", 1); //receta nombre
                    cmd.Parameters.AddWithValue("@id_ingrediente", detalleReceta[i].Ingrediente.IngredienteId); //receta tipo receta
                    cmd.Parameters.AddWithValue("@cantidad", detalleReceta[i].Cantidad); //receta cheff

                }


                afectadas = cmd.ExecuteNonQuery();





                t.Commit(); //CONFIRMA QUE LA TRANSACCION SEA EXITOSA
            }
            catch (SqlException ex)
            {
                if (t != null) { t.Rollback(); }

                Console.WriteLine(ex);

            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }

            return afectadas;

        }



    }
}
