using EquipoQ22.Domino;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipoQ22.Datos
{
    class Context
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

        public int GuardarBD(Equipo equipo)
        {
            SqlTransaction transaction = null;
            int rowAffecteds = 0;
            int equipoId = 0;

            try
            {

                context.Open();
                transaction = context.BeginTransaction();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_INSERTAR_EQUIPO";
                cmd.Connection = context;
                cmd.Transaction = transaction;
                cmd.Parameters.AddWithValue("@pais", equipo.Pais);
                cmd.Parameters.AddWithValue("@director_tecnico", equipo.DirectorTecnico);
                SqlParameter parameterOut = new SqlParameter("@id", SqlDbType.Int);
                parameterOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parameterOut);
                rowAffecteds = cmd.ExecuteNonQuery();
                equipoId = (int)parameterOut.Value;

                for (int i = 0; i < equipo.Jugadores.Count; i++)
                {
                    SqlCommand _cmd = new SqlCommand();
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.CommandText = "SP_INSERTAR_DETALLES_EQUIPO";
                    _cmd.Connection = context;
                    _cmd.Transaction = transaction;
                    _cmd.Parameters.AddWithValue("@id_equipo",equipoId);
                    _cmd.Parameters.AddWithValue("@id_persona", equipo.Jugadores[i].Persona.IdPersona);
                    _cmd.Parameters.AddWithValue("@camiseta", equipo.Jugadores[i].Camiseta);
                    _cmd.Parameters.AddWithValue("@posicion", equipo.Jugadores[i].Posicion);

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
            

            }
            finally
            {
                if (context != null && context.State == ConnectionState.Open)
                    context.Close();

            }

            return rowAffecteds;

        }

        public List<Persona> ObtenerPersonas()
        {
            Persona persona = new Persona();
            List<Persona> personas = new List<Persona>();
            DataTable table = GetFromDataBase("SP_CONSULTAR_PERSONAS");

            persona.NombreCompleto = table.Rows[1].ItemArray[1].ToString();

            persona.Clase = (int)table.Rows[2].ItemArray[2];

             personas.Add(persona);

            return personas;
        }
        


      
    }
}


