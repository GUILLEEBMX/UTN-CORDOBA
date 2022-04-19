using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA
{
    public class Autor
    {

        private int cantidadAutores;
        

        public Autor(int cantidadAutores)
        {
            this.cantidadAutores = cantidadAutores;

            Autores = new string[cantidadAutores];
        }

        public Autor()
        {

        }

        public string[] Autores { get; set; }

        public string Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public int Edad
        {
            get { return Edad; }
            set { Edad = value;}
        }

        public bool Sexo
        {
            get { return Sexo; }
            set { Sexo = value; }
        }

        public double Altura
        {
            get { return Altura; }
            set { Altura = value; }
        }

       
        public void AñadirAutores(string nombre,int index)
        {
            if (index > cantidadAutores)
            {
                throw new Exception("ERROR INDEX OUT OF RANGE..."); 
            }

            Autores[index] = nombre;
        }

        public string [] MostrarAutores()
        {
            return Autores;
        }

        






    }
}
