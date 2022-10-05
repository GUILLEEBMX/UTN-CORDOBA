using EquipoQ22.Domino;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipoQ22.Datos
{
    public interface IEquipoDao
    {
        //ESTA INTERFAZ HABRIA QUE MIGRARLA A LA CARPETA SERVICES
        //PERO POR LAS DUDAS QUE AL MOVERLO NO ENCONTRARA EL NAMESPACE O ALGO POR EL ESTILO
        //DECIDI DEJARLA ACA...
        List<Persona> ObtenerPersonas();
        //bool CrearEquipo(Equipo equipo);


        void CargarPersonas(ComboBox comboBox);

        int GuardarBD(Equipo equipo);
   

    }
}
