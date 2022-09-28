using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    public class Receta
    {
        public int RecetaNro { get; set; }

        public string Nombre { get; set; }


        public int TipoReceta { get; set; }


        public string Cheff { get; set; }

        public List <DetalleReceta> DetalleReceta { get; set; }  //SE INICIAN EN NULL



        public void AgregarDetalle(DetalleReceta detalle)
        {
            if (DetalleReceta == null)
            {
                DetalleReceta = new List<DetalleReceta>(); //SI LA RECETA ES NULA CREAMELA 
            }

            DetalleReceta.Add(detalle);
        }
    }
}
