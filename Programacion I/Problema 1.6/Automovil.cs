using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1._6
{
    class Automovil
    {
        private double cantidad_KM;
        private int tanque = 54;
        private double litros;
        private double nivel_actual_litros;
        private double litros_cargar;



        public double CantidadKM

        {
            get { return cantidad_KM; }
            set { cantidad_KM = value; }

        }

        public int Tanque

        {
            get { return tanque; }

        }

        public double Litros

        {
            get { return litros; }
            set { litros = value; }

        }

        public double NivelActualLitros

        {
            get { return nivel_actual_litros; }
            set { nivel_actual_litros = value; }

        }

        public double LitrosCargar

        {
            get { return litros_cargar; }
            set { litros_cargar = value; }

        }

        public Automovil()

        {
            cantidad_KM = 0;
            tanque = 54;
            litros = 0;
            nivel_actual_litros = 0;
            litros_cargar = 0;
        }

        public Automovil(double cantidad_KM, double litros, double nivel_actual_litros, double litros_cargar, int tanque = 54)

        {
            this.cantidad_KM = cantidad_KM;
            this.litros = litros;
            this.tanque = tanque;
            this.nivel_actual_litros = nivel_actual_litros;
            this.litros_cargar = litros_cargar;
        }


        public string Conducir()

        {
            double litros_necesarios;
            double litros_restantes;

            litros_necesarios = ((cantidad_KM * 1) / 11);

            litros_restantes = nivel_actual_litros - litros_necesarios;

            if (litros_necesarios > tanque)
                return "NO SE PUEDE REALIZAR EL RECORRIDO";
            else
                if (litros_necesarios > nivel_actual_litros)
                return "NO SE PUEDE REALIZAR EL RECORRIDO";
            else
                return $"{"SE UTILIZARAN " + litros_necesarios + " LITROS "}\r\n{ "Y QUEDARAN DISPONIBLES " + litros_restantes + "LITROS "}";


        }

        public string Cargar()

        {
            double total;

            double derramados;



            total = (nivel_actual_litros + litros_cargar);

            derramados = (total - tanque);


            if (total >= tanque)
                return "LA CANTIDAD DE LITROS DERRAMADOS SERA DE: " + derramados + " LITROS";
            else
                if (total < tanque)
                return "EL TOTAL DE COMBUSTIBLE QUE TENDRA EL TANQUE SERA DE: " + total + " LITROS";


            return "";

        }
    }
}
