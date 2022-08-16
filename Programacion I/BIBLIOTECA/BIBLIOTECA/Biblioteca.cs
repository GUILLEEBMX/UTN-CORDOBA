using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BIBLIOTECA
{
    public class Biblioteca
    {
        private static Autor autor = new Autor();
        Libro _libro = new Libro(5, "TEST ISBN","HARRY POTTER", autor);
        private static Libro libro1 = new Libro();

        private int cantidadLibros;
        private Libro[] libros; // Asociación entre BIBLIOTECA y LIBROS de tipo 1..*
        private string[] librosISBN;

       

        public Biblioteca(int cantidad)
        {
            cantidadLibros = cantidad;
            libros = new Libro[cantidad];
            librosISBN = new string[cantidadLibros];

        }


        public void AgregarLibro(Libro libro,int index)
        {
           if (index > cantidadLibros)
            {
                throw new Exception("INDEX OUT OF RANGE...");
            }
            libros[index] = libro;
            
        }

        public void QuitarLibro(string ISBN)
        {
            for (int i = 0; i < cantidadLibros; i++)
            {
                if (libros[i].ISBN == ISBN)
                {
                    libros[i].ISBN = null;
                    
                }
            }

        }


        public void AgregarLibroISBN(string ISBN, int index)
        {

           if (index > cantidadLibros)
           {
                throw new Exception("INDEX OUT OF RANGE...");
           }
            librosISBN[index] = ISBN;
        }

        public void QuitarLibroISBN(string ISBN)
        {
            for (int i = 0; i < cantidadLibros; i++)
            {
                if (librosISBN[i] == ISBN)
                {
                    librosISBN[i] = null;
                }
            }
        }

        public string [] MostrarLibrosISBN()
        {
            return librosISBN;
        }

        public Libro[] MostrarLibros()
        {
            return libros;
        }





    }
}
