using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosPrimerParcial
{
    class Gasto
    {
        private Responsable responsable;

        public Gasto()
        {
            responsable = new Responsable();
         
        }

        public Gasto(int monto)
        {
            this.Monto = monto;
        }
        public string Descripcion { get; set; }
        public double Monto { get; set; }
        public double Estado { get; set; }

        

        public override string ToString()
        {
             return "Descripción: " + Descripcion + "Monto: " + Monto + "Estado: " + Estado;

        }


        public double CalcularImporteFinal()
        {
            Responsable responsable = new Responsable();
            //CREE UN RESPONSABLE ACÁ PARA QUE NO ME DE ERROR DE NULL REFERENCES...

            return responsable.CalcularCostoHoras() + Monto;
        }






    }
}
