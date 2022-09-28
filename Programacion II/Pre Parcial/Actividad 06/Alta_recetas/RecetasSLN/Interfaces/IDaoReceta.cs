using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.Interfaces
{
    public interface IDaoReceta
    {

        DataTable ConsultarSQL(string SP);

        int EjecutarSQL(string SP,Receta receta);

        int InsertarDetalle(string SP, List<DetalleReceta> detalleReceta);



    }
}
