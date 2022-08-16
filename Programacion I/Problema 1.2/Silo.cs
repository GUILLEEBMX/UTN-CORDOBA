using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1._2
{
    class Silo
    {
        private double pi = 3.14;
        private double radio;
        private double altura;


        public double PI
        {
            get { return pi; }

        }

        public double Radio
        {
            get { return radio; }

            set { radio = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public Silo(double pi, double altura, double radio)
        {
            this.pi = pi;
            this.altura = altura;
            this.radio = radio;
        }

        public Silo()
        {

        }

        public double CalcularVolumen()
        {
            double volumen = (radio * radio * pi * altura);

            return volumen;
        }

    }
}
