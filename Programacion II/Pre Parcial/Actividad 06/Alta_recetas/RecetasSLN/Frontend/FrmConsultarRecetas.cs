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

        private void FrmConsultarRecetas_Load(object sender, EventArgs e)
        {
            servicePrescription.LoadCBOIngredients(cboIngredients);
            servicePrescription.LoadCBOPrescriptionTypes(cboPrescriptionTypes);
            servicePrescription.NextPrescription(lblTotal);
          
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           servicePrescription.LoadDataGridView(dgvPrescription);
        }

    }
}
