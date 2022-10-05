using EquipoQ22.Datos;
using EquipoQ22.Domino;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipoQ22.DAO
{
    class EquipoDAO:IEquipoDao
    {
        public List<Persona> ObtenerPersonas()
        {

           return  Context.GetInstance().ObtenerPersonas();

        }


        public void CargarPersonas(ComboBox comboBox)
        {
            
            DataTable table = new DataTable();
            table = Context.GetInstance().GetFromDataBase("SP_CONSULTAR_PERSONAS");

            comboBox.DataSource = table;
            comboBox.ValueMember = table.Columns[0].ColumnName;
            comboBox.DisplayMember = table.Columns[1].ColumnName;
        }


        public int GuardarBD(Equipo equipo)
        {
            return Context.GetInstance().GuardarBD(equipo);

        }


      
    }
}
