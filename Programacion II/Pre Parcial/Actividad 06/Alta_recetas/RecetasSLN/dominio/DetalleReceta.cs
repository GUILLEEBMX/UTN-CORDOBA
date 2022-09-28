using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    public class DetalleReceta
    {
     
        public DetalleReceta()
        {
            Ingrediente = new Ingrediente();

        }


        public Ingrediente Ingrediente { get; set; }

        public int Cantidad { get; set; }


    }
}
