using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA
{
    public class Persona
    {
        private string nombre;
        private int edad;
        private bool sexo;
        private double altura;
        private double peso;

        public Persona()
        {

        }

        public Persona(string nombre,int edad, bool sexo, double altura,double peso)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.altura = altura;
            this.peso = peso;

        }
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

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public override string ToString ()
        {
            return "NOMBRE:" + nombre + "\nEDAD:" + edad + "\nSEXO:" + sexo + "\nALTURA:" + altura + "\nPESO:" + peso;

        }




    }
}
