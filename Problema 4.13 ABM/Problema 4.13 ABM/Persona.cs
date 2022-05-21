using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4._13_ABM
{
    class Persona
    {
      

        public Persona()
        {

        }

        public string Apellido {get;set;}
        public string Nombres { get; set; }

        public int TipoDNI { get; set; }

        public int Documento { get; set; }

        public int EstadoCivil { get; set; }

        public int Sexo { get; set; }

        public int Fallecido { get; set; }




        public override string ToString()
        {
            return  Nombres + " " + Apellido;
                  /* "\nTipo DNI:" + TipoDNI + 
                   "\nDocumento" + Documento + 
                   "\nEstado Civil:" + EstadoCivil+ 
                   "\nSexo:" + Sexo;*/

            
        }



    }

    
}
