using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASSWORD
{
    class PASSWORD
    {
        private int longitud = 8;
        private int valor;
        private int contnumeros;
        private int contminusculas;
        private int contmayusculas;
        private string numeros = "0123456789";
        private string mayusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string minusculas = "abcdefghijklmnopqrstuvwxyz";

        public int pLongitud

        {
            get { return longitud; }
            set { longitud = value; }

        }

        public int pValor

        {
            get { return valor; }
            set { valor = value; }

        }

        public int Pcontnumeros

        {
            get { return contnumeros; }
            set { contnumeros = value; }
        }

        public int Pcontminusculas
        {
            get { return contminusculas; }
            set { contminusculas = value; }

        }

        public int Pcontmayusculas
        {
            get { return contmayusculas; }
            set { contmayusculas = value; }

        }

        public string Pnumeros
        {
            get { return numeros; }
        }

        public string Pmayusculas
        {
            get { return mayusculas; }
        }

        public string Pminusculas
        {
            get { return minusculas; }
        }











        public PASSWORD()
        {
            longitud = 8;
            valor = 0;
            contmayusculas = 0;
            contminusculas = 0;
            contnumeros = 0;
        }

        public PASSWORD(int valor, int contnumeros, int contmayusculas, int contminusculas, string numeros, string mayusculas,string minusculas, int longitud = 8)

        {
            this.longitud = longitud;
            this.valor = valor;
            this.contnumeros = contnumeros;
            this.contmayusculas = contmayusculas;
            this.contnumeros = contnumeros;
            this.numeros = numeros;
            this.mayusculas = mayusculas;
            this.minusculas = minusculas;
        }


        public bool EsFuerte()

        {


            if (contnumeros >= 1 && contmayusculas >= 1 && contminusculas >= 1)
                return true;
            else
                return false;
        }

        public string GenerarPassword()

        {
            
            string aleatoria = "";
            string caracteres;
            char letra;

           

            Random RDN = new Random();

            caracteres = numeros + mayusculas + minusculas;
            for (int i = 0; i < longitud; i++)
            {
                letra = caracteres[RDN.Next(caracteres.Length)];
                aleatoria += letra.ToString();

            }



            return aleatoria;





        }

        


    }

}
