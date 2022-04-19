using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIBLIOTECA
{
    public class Libro
    {
        private Autor autor;
        private int cantidadLibros;
        private string _ISBN;
        private int paginas;
        private string titulo;


        public Libro(int cantidadLibros, string ISBN,string titulo, Autor autor)
        {
            autor = new Autor(5);
            this.cantidadLibros = cantidadLibros;
            Libros = new string[cantidadLibros];
            this.ISBN = ISBN;
            this.autor = autor;
            this.titulo = titulo;

        }

        public Libro()
        {
            autor = new Autor(5);
            
            
        }

        public string[] Libros {get;set;}

        public string ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public int Paginas
        {
            get { return paginas; }
            set { paginas = value; }
        }

        public void AñadirLibros(string nombreLibro,string autores,int index)
        {
            if (index > cantidadLibros)
            {
                throw new Exception("ERROR OUT OF INDEX...");
            }
            Libros[index] = nombreLibro + " " + autores; 
            
           
        }

        public string [] MostrarLibros()
        {
            return Libros;
        }










    }
}
