using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA
{
    public class Autor :Persona
    {

        private int cantidadAutores;
        private string editorial;

        

        public Autor(int cantidadAutores, string nombre, int edad, bool sexo, double altura, double peso) : base(nombre,edad,sexo,altura,peso)
        {
            this.cantidadAutores = cantidadAutores;

            Autores = new string[cantidadAutores];
        }

        public Autor(): base()
        {

        }

        public string[] Autores { get; set; }
        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
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

        public override string ToString()
        {
            return base.ToString() + "\nEDITORIAL:" + editorial;
        }










    }
}
