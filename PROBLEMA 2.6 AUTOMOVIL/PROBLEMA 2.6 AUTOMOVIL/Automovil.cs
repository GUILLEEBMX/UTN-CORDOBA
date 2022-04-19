using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA_2._6_AUTOMOVIL
{
    class Automovil
    {
        private Tanque Tanque;
        private int odometro;
        private int consumo;




        public Automovil()
        {
            odometro = 0;
            consumo = 11;
            Tanque = new Tanque();

        }

        public Automovil(int km, int ltsActuales)

        {
            Tanque = new Tanque();
            this.odometro = km;


        }

        public int Odometro

        {

            get { return odometro; }

            set { odometro = value; }

        }

        public int Consumo

        {
            get { return consumo; }

        }



        public bool Conducir(int km, double litrosActuales)
        {

            double litrosNecesarios = Tanque.ConsumirCombustible(km);

            double litrosTotales = Tanque.Capacidad + Tanque.Reserva;

            if (litrosNecesarios > litrosTotales || litrosNecesarios > litrosActuales)
                return false; 
            else
                return true; 

        }



        override

        public string ToString()
        {

            return "Km: " + odometro + " | Nivel de combustible: " + Tanque.LitrosActuales;

        }
    }
}
