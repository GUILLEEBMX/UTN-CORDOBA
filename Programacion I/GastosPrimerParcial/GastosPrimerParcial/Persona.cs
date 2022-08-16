using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosPrimerParcial
{
    class Persona
    {
        public string Nombre { get; set; }

        public int DNI { get; set; }

        public string Sexo { get; set; }

        public override string ToString()
        {
            return "Nombre" + Nombre + "\nDNI: " + DNI + "\nSEXO:" + Sexo;
        }




    }
}
