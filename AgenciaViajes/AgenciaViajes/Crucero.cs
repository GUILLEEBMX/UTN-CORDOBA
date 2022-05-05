using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes
{
    class Crucero : PaqueteTuristico
    {
        private AtraccionTuristica atraccionTuristica;
       
        public Crucero() : base ()
        {
            atraccionTuristica = new AtraccionTuristica();
        }
      
        public int CantidadEstrellas
        {
            get { return CantidadEstrellas; }
            set { CantidadEstrellas = value; }
        }

        //public override string ToString()
        //{
        //    return "Atraccion: " + "CantidadEstrellas" + CantidadEstrellas;
        //}

        public double CalcularCostoFinal ()
        {
            return atraccionTuristica.Costo + CostoDiario  * Duracion  ;

        }



    }
}
