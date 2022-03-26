using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1._4
{
    class Persona
    {

        private string nombre;
        private int edad;
        private bool sexo;
        private double peso;
        private double altura;

        public string Nombre
        {
            get { return nombre; }

            set { nombre = value; }

        }

        public int Edad
        {
            get { return edad; }

            set { edad = value; }

        }

        public bool Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public Persona()
        {

        }
        public Persona(string nombre, int edad, bool sexo, double altura, double peso)

        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.altura = altura;
            this.peso = peso;
        }



        public double CalcularIMC()
        {
            double imc = peso / (altura * altura);

            if (imc < 20)
            {
                return -1;
            }

            if (imc > 20 && imc <= 25)
            {
                return 0;
            }

            if (imc > 25)
            {
                return 1;
            }

            return imc;
        }

        public bool EsMayor()
        {

            if (edad >= 21)
                return true;
            else
                return false;

        }
    }
}
