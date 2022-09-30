using APIPrescription.Domain;
using APIPrescription.FactoryConfig;
using APIPrescription.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIPrescription
{
    public partial class FormPrescription : Form
    {
        private IPrescriptionService prescription;
        IFormValidatorService validator;
        private FactoryService factoryService;
        private Prescription _prescription;
        private PrescriptionDetails prescriptionDetails;
        public FormPrescription(FactoryService factoryService)
        {
            InitializeComponent();
            this.factoryService = factoryService;
            prescription = factoryService.CreateServices();
            validator = factoryService.CreateValidatorServices();
        }

        private void FormPrescription_Load(object sender, EventArgs e)
        {
            prescription.LoadCBOPrescriptionTypes(cboPrescriptionType);
            prescription.LoadCBOIngredients(cboIngredients);
            lblPrescriptionNumber.Text = lblPrescriptionNumber.Text + " " + prescription.NextPrescription();

            _prescription = new Prescription();
            prescriptionDetails = new PrescriptionDetails();
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!validator.ValidateFields(txtName))
            {
                MessageBox.Show("EL CAMPO NOMBRE NO PUEDE ESTAR VACIO");
                txtName.Focus();
                return;

            }

            if (!validator.ValidateFields(txtCheff))
            {
                MessageBox.Show("EL CAMPO CHEFF NO PUEDE ESTAR VACIO");
                txtCheff.Focus();
                return;

            }

            if (!validator.ValidateFields(txtAmount))
            {
                MessageBox.Show("EL CAMPO CANTIDAD NO PUEDE ESTAR VACIO");
                txtAmount.Focus();
                return;

            }
            _prescription.Nombre = txtName.Text;
            _prescription.Cheff = txtCheff.Text;
            _prescription.PrescriptionType.Type = cboPrescriptionType.SelectedValue.ToString();
            prescriptionDetails.Ingredient.Name = cboIngredients.Text;
            prescriptionDetails.Amount = int.Parse(txtAmount.Text);
            _prescription.AddDetail(prescriptionDetails);



            if (!validator.ValidateIngredients(dgvPrescription, cboIngredients))
            {
                dgvPrescription.Rows.Add(new object[]
            {

                10,
                prescriptionDetails.Ingredient.Name,
                prescriptionDetails.Amount,

           });

                lblTotalIngredients.Text = "Total Ingredients:  " + (dgvPrescription.Rows.Count - 1).ToString();

            }
            else
            {
                MessageBox.Show("NO SE PUEDEN AGREGAR INGREDIENTES REPETIDOS");
            }



        }



        private void btnAcept_Click(object sender, EventArgs e)
        {
            if (validator.ValidateAmountIngredients(dgvPrescription))
            {
                int flagToShow = prescription.PostToDataBase(_prescription);

                if (flagToShow > 0)
                {
                    if (MessageBox.Show("LA INSERCION SE REALIZO CORRECTAMENTE") == DialogResult.OK)
                    {
                        ClearAllDisplay();
                    }
                }
                else
                {
                    MessageBox.Show("OCURRIO UN ERROR AL INSERTAR VERIFICAR...");
                }
            }
            else
            {
                MessageBox.Show("DEBERA INGRESAR AL MENOS 3 INGREDIENTES");
                dgvPrescription.Focus();
                return;

            }


        }


        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.ValidatorOnlyNumbers(sender, e);
        }

        private void lblTotalIngredients_Click(object sender, EventArgs e)
        {

        }

        private void ClearAllDisplay()
        {
            txtName.Clear();
            txtCheff.Clear();
            txtAmount.Clear();
            dgvPrescription.Rows.Clear();
            cboIngredients.SelectedIndex = 0;
            cboPrescriptionType.SelectedIndex = 0;
            txtName.Focus();
            lblTotalIngredients.Text = "TotalIngredients: " + 0;


        }

        private void txtAmount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
