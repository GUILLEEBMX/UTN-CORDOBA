using System;

namespace BIBLIOTECA
{
    class Program
    {
        static void Main(string[] args)
        {
            //AÑADIR AUTORES

            Console.WriteLine("INGRESA LA CANTIDAD DE AUTORES...");
            int cantidadAutores = int.Parse(Console.ReadLine());
            Autor autor = new Autor(cantidadAutores);
            Console.WriteLine("\nINGRESA LOS NOMBRES DE LOS AUTORES");
            for (int i = 0; i < cantidadAutores; i++)
            {
                string nombres = Console.ReadLine();
                autor.AñadirAutores(nombres, i);
            }

            ////MUESTRA LOS AUTORES AÑADIDOS...

            Console.WriteLine("\nESTOS SON LOS AUTORES AÑADIDOS:");
            for (int i = 0; i < cantidadAutores; i++)
            {
                Console.WriteLine(autor.MostrarAutores()[i]);
            }


            //////AÑADIR LIBROS Y AUTORES:

            Console.WriteLine("\nINGRESA LA CANTIDAD DE LIBROS...");
            int cantidadLibros = int.Parse(Console.ReadLine());
            Libro libro = new Libro(cantidadLibros,"TEST ISBN","HARRY POTTER",autor);

            for (int i = 0; i < cantidadLibros; i++)
            {
                Console.WriteLine("INGRESA EL NOMBRE DEL LIBRO...");
                string nombreLibro = Console.ReadLine();
                Console.WriteLine("INGRESA EL NOMBRE DEL AUTOR...");
                string autores = Console.ReadLine();
                libro.AñadirLibros(nombreLibro, autores, i);
            }

            //////MOSTRAR LIBROS Y AUTORES:

            Console.WriteLine("\nLOS NOMBRES DE LOS LIBROS + LOS AUTORES SON:");
            for (int i = 0; i < cantidadLibros; i++)
            {
                Console.WriteLine(libro.MostrarLibros()[i]);
                //Console.WriteLine(libro.MostrarLibros()[i] + " " + Autor.MostrarAutores()[i]);
                //ACA SE PUEDE SETEAR PARA QUE LOS NOMBRES DE AUTORES QUE SE PASARON ARRIBA SE ASIGNEN A UN LIBRO DIRECTAMENTE
                //SIN NECESIDAD DE TENER QUE AGREGAR EL AUTOR NUEVAMENTE... 

            }


            //AÑADIR LIBRO A BIBLIOTECA
            //ACA USE ESTA FUNCION RANDOM PARA PODER GENERAR ISBNs Y
            //TITULOS DE MANERA ALEATORIA PARA NO TENER QUE COMPLETARLOS A MANO JAJA Y QUE POR CADA VUELTA DEL CICLO
            //ME ASIGNE UN LIBRO CON UN ISBN Y UN TITULO DISTINTO...
            Random r = new Random();
            string ISBN;
            Biblioteca biblioteca = new Biblioteca(cantidadLibros);
            for (int i = 0; i < cantidadLibros; i++)
            {
                Libro libro1 = new Libro(cantidadLibros, r.Next(1000, 10000).ToString(),r.Next(10,101).ToString(), autor);
                biblioteca.AgregarLibro(libro1,i);
            }

            Console.WriteLine("\nESTOS SON LOS ISBN DE LOS LIBROS AÑADIDOS...");
            for (int i = 0; i < cantidadLibros; i++)
            {
                Console.WriteLine("ISBN:" + biblioteca.MostrarLibros()[i].ISBN);
            }

            //ELIMINAR LIBRO POR ISBN DEL ARRAY LIBROS []

            Console.WriteLine("\nINGRESA EL ISBN DEL LIBRO [] QUE DESEAS ELIMINAR...");
            ISBN = Console.ReadLine();
            biblioteca.QuitarLibro(ISBN);



            //MOSTRAR LIBROS RESTANTES DEL  ARRAY DE LIBROS []
            Console.WriteLine("\nLOS LIBROS CUYO ISBN RESTANTES SON:");
            for (int i = 0; i < cantidadLibros; i++)
            {
                if(biblioteca.MostrarLibros()[i].ISBN != null)
                {
                    Console.WriteLine(biblioteca.MostrarLibros()[i].ISBN);
                }
                
            }


            //AÑADIR LIBRO A BIBLIOTECA POR ARRAY STRING ISBN []

            Console.WriteLine("\nINGRESA EL ISBN DEL LIBRO QUE DESEAS AGREGAR...");
            for (int i = 0; i < cantidadLibros; i++)
            {
                ISBN = Console.ReadLine();
                biblioteca.AgregarLibroISBN(ISBN, i);

            }


            // MOSTRAR LIBROS AÑADIDOS A BIBLIOTECA POR ARRAY STRING ISBN []

            for (int i = 0; i < cantidadLibros; i++)
            {
                Console.WriteLine(biblioteca.MostrarLibrosISBN()[i]);
            }

            //ELIMINAR LIBROS AÑADIDOS POR ARRAY STRING ISBN []

            Console.WriteLine("\nINGRESA EL ISBN DEL LIBRO QUE DESEAS QUITAR...");
            ISBN = Console.ReadLine();

            for (int i = 0; i < cantidadLibros; i++)
            {

                biblioteca.QuitarLibroISBN(ISBN);
            }


            //MOSTRAR LIBROS RESTANTES POR ARRAY STRING ISBN []

            Console.WriteLine("\nLOS LIBROS CUYO ISBN RESTANTES SON:...");

            for (int i = 0; i < cantidadLibros; i++)
            {
                if (biblioteca.MostrarLibrosISBN()[i] != null)
                {
                    Console.WriteLine(biblioteca.MostrarLibrosISBN()[i]);
                }

            }























        }
    }
}
