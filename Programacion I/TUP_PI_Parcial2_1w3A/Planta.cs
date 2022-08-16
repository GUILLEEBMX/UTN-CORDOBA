using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUP_PI_Parcial2_1w3A
{
    class Planta
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private int especie;

        public int Especie
        {
            get { return especie; }
            set { especie = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public Planta()
        {
            this.codigo = 0;
            this.nombre = "";
            this.precio = 0;
            this.especie = 0;
            this.fecha = DateTime.Today;
        }

        public Planta(int codigo, string modelo, double precio, int marca, DateTime fecha)
        {
            this.codigo = codigo;
            this.nombre = modelo;
            this.precio = precio;
            this.especie = marca;
            this.fecha = fecha;
        }

        public override string ToString()
        {
            return codigo + " - " + nombre + " - " + precio;
        }
    }
}
