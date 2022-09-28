using RecetasSLN.Config;
using RecetasSLN.dominio;
using RecetasSLN.Implementacion;
using RecetasSLN.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetasSLN.presentación
{
    public partial class FrmConsultarRecetas : Form
    {
        private IPrescriptionService servicePrescription;
        private FactoryService factoryService;
        private Prescription prescription;
        private DetailPrescription detailPrescription;
        public FrmConsultarRecetas(FactoryService factoryService)
        {
            InitializeComponent();
            this.factoryService = factoryService;
            servicePrescription = factoryService.CreateServices();
            prescription = new Prescription();
            detailPrescription = new DetailPrescription();
        }

        private void cboTipoReceta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmConsultarRecetas_Load(object sender, EventArgs e)
        {
            LoadCBOIngredients();
            LoadCBOPrescriptionTypes();
          

          

        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {


            prescription.PrescriptionType = (int)cboPrescriptionTypes.SelectedValue;
            prescription.Name = txtName.Text;
            prescription.Cheff = txtCheff.Text;
            detailPrescription.Ingredient.IngredientId = (int)cboIngredients.SelectedValue;
            detailPrescription.Amount = 5;
            prescription.AddDetails(detailPrescription);

            int flagToShow = servicePrescription.PostToDataBase(prescription);

            if (flagToShow > 1)
            {
                MessageBox.Show("The Insertion has been successfully");
            }
        }

        private void cboIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {





        }

        private void LoadCBOIngredients()
        {
            cboIngredients.DataSource = servicePrescription.GetFromDataBaseIngredients();
            cboIngredients.DisplayMember = servicePrescription.GetFromDataBaseIngredients().Columns[1].ColumnName;
            cboIngredients.ValueMember = servicePrescription.GetFromDataBaseIngredients().Columns[0].ColumnName;
        }

        private void LoadCBOPrescriptionTypes()
        {
            cboPrescriptionTypes.DataSource = servicePrescription.GetFromDataBasePrescriptionTypes();
            cboPrescriptionTypes.DisplayMember = servicePrescription.GetFromDataBasePrescriptionTypes().Columns[1].ColumnName;
            cboPrescriptionTypes.ValueMember = servicePrescription.GetFromDataBasePrescriptionTypes().Columns[0].ColumnName;
        }

        private void LoadDataGridView()
        {
            for (int i = 0; i < servicePrescription.GetFromDataBasePrescriptions().Rows.Count; i++)
            {

                dgvPrescription.Rows.Add(new object[]
                {
                 servicePrescription.GetFromDataBasePrescriptions().Rows[i].ItemArray[1],
                 servicePrescription.GetFromDataBasePrescriptions().Rows[i].ItemArray[3],
                 servicePrescription.GetFromDataBasePrescriptions().Rows[i].ItemArray[2]
                });
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
