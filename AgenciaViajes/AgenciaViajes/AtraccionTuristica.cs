using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes
{
    class AtraccionTuristica
    {
        private string nombre;
        private double costo;

        public AtraccionTuristica()
        {
        }

      public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }


        public override string ToString()
        {
            return "Nombre" + nombre + "Costo " + Costo;
        }




    }
}
