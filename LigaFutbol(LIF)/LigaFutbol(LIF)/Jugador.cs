﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaFutbol_LIF_
{
    class Jugador : Persona
    {
        private string posicion;
        private bool lesionado = true;
        private int faltas;

        public Jugador()
        {

        }
        public Jugador(string nombre, string apellido,string fechaDeNacimiento,string grupoSanguineo,
           string posicion,bool lesionado, int faltas ):base(nombre,apellido,fechaDeNacimiento,grupoSanguineo)
        {
            this.posicion = posicion;
            this.lesionado = lesionado;
            this.faltas = faltas;

        }

        public string Posicion
        {
            get { return posicion; }
            set { posicion = value; }
        }

        public bool Lesionado
        {
            get { return lesionado; }
            set { lesionado = value; }
        }

        public int Faltas
        {
            get { return faltas; }
            set { faltas = value; }
        }

        public int Valoracion (bool lesionado, int faltas)
        {
            if (lesionado == false && faltas == 0)
            {
                return 5;
            }
            else
            {
                return 10;
            }
        }

        public bool EstaSuspendido(int faltas)
        {
            if (faltas > 3)
            {
                return true;
            }
            else
            {
                return false;
            }
                

        }


        public override string ToString()
        {
            return "Posicion:" + posicion + "\nEsta Lesionado:" + lesionado + "\nFaltas:" + faltas + base.ToString();
        }









    }
}
