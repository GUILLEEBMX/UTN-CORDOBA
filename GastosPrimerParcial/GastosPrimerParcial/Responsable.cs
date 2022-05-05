using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosPrimerParcial
{
    class Responsable : Persona
    {
        public Responsable() : base ()
        {

        }

        public int Legajo { get; set; }
        public double HorasAfectadas { get ; set ; }
        public double ValorHora { get; set; }

        public override string ToString()
        {
            return "Legajo" + Legajo + "\nHorasAfectadas: " + HorasAfectadas + "ValorHora: " + ValorHora; 
        }

        public double CalcularCostoHoras()
        {
            Random r = new Random();
            //CREE ESTE OBJETO RANDOM PARA SETEAR DIFERENTES HORAS AFECTADAS Y VALORES HORAS;

            HorasAfectadas = r.Next(1, 50);

            ValorHora = r.Next(1, 300);

            return HorasAfectadas * ValorHora;
        }

       


    }
}
