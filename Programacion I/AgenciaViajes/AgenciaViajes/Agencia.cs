using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes
{
    class Agencia
    {
        private Crucero[] cruceros;
        private int cantidadPaquetes;
        public Agencia(int cantidadPaquetes)
        {

            this.cantidadPaquetes = cantidadPaquetes;
            cruceros = new Crucero[cantidadPaquetes];
        }

        public int CantidadCruceros
        {
            get { return cantidadPaquetes; }
            set { cantidadPaquetes = value; }
        }
        public string Paquetes
        {
            get { return Paquetes; }
            set { Paquetes = value; }
        }

        public void RegistrarCrucero(int index, Crucero crucero)
        {
            if (index > cantidadPaquetes)
            {
                throw new Exception("INDEX OUT OF RANGE...");
            }
            cruceros[index] = crucero;
        }


        public Crucero[] MostrarCruceros()
        {
            return cruceros;
        }

       


    }
}
