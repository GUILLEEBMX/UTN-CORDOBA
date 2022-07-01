using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUP_PI_Recuperatorio_1W3
{
    class Gasto
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private int dia;

        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        private int categoria;

        public int Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        private int medioPago;

        public int MedioPago
        {
            get { return medioPago; }
            set { medioPago = value; }
        }
        private double importe;

        public double Importe
        {
            get { return importe; }
            set { importe = value; }
        }

        public Gasto(int codigo, int dia, int categoria, int medioPago, double importe)
        {
            this.codigo = codigo;
            this.dia = dia;
            this.categoria = categoria;
            this.medioPago = medioPago;
            this.importe = importe;
        }

        public Gasto()
        {
            this.codigo = 0;
            this.dia = 0;
            this.categoria = 0;
            this.medioPago = 0;
            this.importe = 0;
        }

        public override string ToString()
        {
            return codigo + " - " + dia + " - $" + importe;
        }
    }
}
