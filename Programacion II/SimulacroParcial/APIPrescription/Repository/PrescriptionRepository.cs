using APIPrescription.Domain;
using APIPrescription.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIPrescription.Repository
{
    class PrescriptionRepository : IPrescriptionService 
    {
        public DataTable GetFromDataBase()
        {
            return Context.Context.GetInstance().GetFromDataBase("SP_CONSULTAR_TIPOS_RECETAS");
        }

        public void LoadCBOPrescriptionTypes(ComboBox comboBox)
        {
            comboBox.DataSource = Context.Context.GetInstance().GetFromDataBase("SP_CONSULTAR_TIPOS_RECETAS");
            comboBox.ValueMember = Context.Context.GetInstance().GetFromDataBase("SP_CONSULTAR_TIPOS_RECETAS").Columns[0].ColumnName;
            comboBox.DisplayMember = Context.Context.GetInstance().GetFromDataBase("SP_CONSULTAR_TIPOS_RECETAS").Columns[1].ColumnName;
        }

        public void LoadCBOIngredients(ComboBox comboBox)
        {
            comboBox.DataSource = Context.Context.GetInstance().GetFromDataBase("SP_CONSULTAR_INGREDIENTES");
            comboBox.ValueMember = Context.Context.GetInstance().GetFromDataBase("SP_CONSULTAR_INGREDIENTES").Columns[0].ColumnName;
            comboBox.DisplayMember = Context.Context.GetInstance().GetFromDataBase("SP_CONSULTAR_INGREDIENTES").Columns[1].ColumnName;
        }

        public int PostToDataBase(Prescription prescription)
        {
            return Context.Context.GetInstance().PostToDataBase(prescription);

        }


        public string NextPrescription()
        {

            return Context.Context.GetInstance().GetFromDataBase("SP_NEXT_RECETA").Rows[0].ItemArray[0].ToString();

        }

    }
}
