using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaFutbol_LIF_
{
    class Persona
    {
        private string nombre;
        private string apellido;
        private string fechaDeNacimiento;
        private string grupoSanguineo;

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, string fechaDeNacimiento, string grupoSanguineo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.grupoSanguineo = grupoSanguineo;

        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;}
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string FechaDeNacimiento
        {
            get { return fechaDeNacimiento; }
            set { fechaDeNacimiento = value; }
        }

        public string GrupoSanguineo
        {
            get { return grupoSanguineo; }
            set { grupoSanguineo = value; }
        }

        public override string ToString()
        {
            return "Nombre: " + nombre + "\nApellido:" + apellido + "\nFecha de Nacimiento:" + fechaDeNacimiento + "\nGrupo Sanguineo:" + grupoSanguineo;
        }







    }
}
