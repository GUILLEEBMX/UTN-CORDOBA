using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosPrimerParcial
{
    class Municipio
    {
        private Gasto[] gastos;
      
        public Municipio()
        {
            gastos = new Gasto [5] ;
        }

        public void RegistrarGasto(int index, Gasto gasto)
        {
            if (index > 5)
            {
                throw new Exception("ERROR");
            }

            gastos[index] = gasto;
        }

        public double MostrarMayorGasto()
        {

            var mayor = gastos[0].CalcularImporteFinal();

            for (int i = 0; i < gastos.Length; i++)
            {
                if (gastos[i].CalcularImporteFinal() > mayor)
                {
                    mayor = gastos[i].CalcularImporteFinal();
                }
            }

            return mayor;
        }

    }
}
