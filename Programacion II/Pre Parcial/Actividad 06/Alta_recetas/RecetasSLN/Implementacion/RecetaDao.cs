using RecetasSLN.datos;
using RecetasSLN.dominio;
using RecetasSLN.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.Implementacion
{
    public class RecetaDao : IDaoReceta 
    {

        public DataTable ConsultarSQL(string SP)
        {

            DataTable t = HelperDB.ObtenerInstancia().ConsultarSQL(SP);


            return t; //SELECT * FROM TABLA
        }

        public int EjecutarSQL(string SP,Receta receta)
        {
            int filasAfectadas = 0;

            filasAfectadas = HelperDB.ObtenerInstancia().EjecutarSQL("SP_INSERTAR_RECETA",receta);

            return filasAfectadas;


        }

       public int InsertarDetalle(string SP, List<DetalleReceta> detalleReceta)
        {
            int filasAfectadas = 0;

            filasAfectadas = HelperDB.ObtenerInstancia().InsertarDetalle(SP,  detalleReceta);

            return filasAfectadas;


        }



    }
}
