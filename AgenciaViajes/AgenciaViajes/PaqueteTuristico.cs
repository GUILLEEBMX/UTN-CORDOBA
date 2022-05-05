using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes
{
    class PaqueteTuristico 
    {

        public PaqueteTuristico() 
        {

        }

        

        public int Numero
        {
            get { return Numero; }
            set { Numero = value; }
        }

        public string Descripcion
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }

        public double CostoDiario
        {
            get { return CostoDiario; }
            set { CostoDiario = value; }
        }

        public int Duracion
        {
            get { return Duracion; }
            set { Duracion = value; }
        }

        public string Destino
        {
            get { return Destino; }
            set { Destino = value; }    
        }

        //public override string ToString()
        //{
        //    return "Numero: " + Numero + "Descripcion" + Descripcion + "CostoDiario:" + CostoDiario + "Duracion" + Duracion + "Destino" + Destino;
        //}

    }
}
