using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA_2._6_AUTOMOVIL
{
    class Tanque
    {
        private double litrosActuales;
        private double capacidad = 49;
        private double reserva = 5;

        public double LitrosActuales
        {
            get { return litrosActuales; }
            set { litrosActuales = value; }
        }

        public double Capacidad
        {
            get { return capacidad; }

        }

        public double Reserva
        {
            get { return reserva; }

        }

        public Tanque()
        {

        }

        public double AgregarCombustible(double litrosCargar, double litrosActuales)
        {
            double litrosDerramados = 0;

            double litrosTotales = litrosCargar + litrosActuales;

            double capacidadTotal = capacidad + reserva;

            if (litrosTotales > capacidadTotal)
            {
                litrosDerramados = (litrosTotales - capacidadTotal);
                return litrosDerramados;

            }
            else
            {
                litrosActuales = litrosCargar + litrosActuales;
                return litrosActuales;
            }



        }

        public double ConsumirCombustible(int km)
        {

            double litrosNecesarios = ((km * 1) / 11);

            return litrosNecesarios;

        }
    }
}
