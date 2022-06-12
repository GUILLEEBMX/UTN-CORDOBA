using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class Mascota
    {
        private int codigo;
        private string nombre;
        private int especie;
        private int sexo;
        private DateTime fechaNacimiento;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Especie
        {
            get { return especie; }
            set { especie = value; }
        }
        public int Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public Mascota()
        {
            this.codigo = 0;
            this.nombre = "";
            this.especie = 0;
            this.sexo = 0;
            this.fechaNacimiento = DateTime.Today;
        }
        public Mascota(int codigo, string nombre, int especie, int sexo, DateTime fechaNacimiento)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.especie = especie;
            this.sexo = sexo;
            this.fechaNacimiento = fechaNacimiento;
        }
        public override string ToString()
        {
            return codigo + " - " + nombre;
        }

    }
}
