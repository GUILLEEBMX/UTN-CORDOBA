using  RecetasSLN.Context;
using RecetasSLN.dominio;
using RecetasSLN.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetasSLN.Implementacion
{
    public class PrescriptionRepository : IPrescriptionService
    {
        public DataTable GetFromDataBaseIngredients()
        {
            return Context.Context.GetInstance().GetFromDataBase("SP_CONSULTAR_INGREDIENTES");
        }

        public DataTable GetFromDataBasePrescriptionTypes()
        {
            return Context.Context.GetInstance().GetFromDataBase("SP_CONSULTAR_TIPOS_RECETAS");
        }

        public int PostToDataBase(Prescription prescription)
        {
            return Context.Context.GetInstance().PostToDataBase("SP_INSERTAR_RECETA", prescription);

        }

        public DataTable GetFromDataBasePrescriptions()
        {
            return Context.Context.GetInstance().GetFromDataBase("SP_CONSULTAR_RECETAS");
        }

        public string NextPrescription(Label lblNextPrescription)
        {
            return Context.Context.GetInstance().NextPrescription(lblNextPrescription);
        }

        public void LoadDataGridView(DataGridView dgvPrescription)
        {
            for (int i = 0; i < GetFromDataBasePrescriptions().Rows.Count; i++)
            {

                dgvPrescription.Rows.Add(new object[]
                {
                GetFromDataBasePrescriptions().Rows[i].ItemArray[1],
                GetFromDataBasePrescriptions().Rows[i].ItemArray[3],
                GetFromDataBasePrescriptions().Rows[i].ItemArray[2]
                });

            }
        }

        public void LoadCBOPrescriptionTypes(ComboBox cboPrescriptionTypes)
        {
            cboPrescriptionTypes.DataSource = GetFromDataBasePrescriptionTypes();
            cboPrescriptionTypes.DisplayMember = GetFromDataBasePrescriptionTypes().Columns[1].ColumnName;
            cboPrescriptionTypes.ValueMember = GetFromDataBasePrescriptionTypes().Columns[0].ColumnName;
        }

        public void LoadCBOIngredients(ComboBox cboIngredients)
        {
            cboIngredients.DataSource = GetFromDataBaseIngredients();
            cboIngredients.DisplayMember = GetFromDataBaseIngredients().Columns[1].ColumnName;
            cboIngredients.ValueMember = GetFromDataBaseIngredients().Columns[0].ColumnName;

        }





    }
}
