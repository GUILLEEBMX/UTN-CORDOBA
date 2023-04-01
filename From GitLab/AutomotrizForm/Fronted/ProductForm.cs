using AutomotrizForm.Services;
using AutomotrizLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizForm.Fronted
{
    public partial class ProductForm : Form
    {
        private readonly IProductClientServices productServices;
        private readonly IValidatorServices validatorServices;
        public ProductForm(IProductClientServices productServices, IValidatorServices validatorServices)
        {
            InitializeComponent();
            this.productServices = productServices;
            this.validatorServices = validatorServices;
        }

        private async void ProductForm_Load(object sender, EventArgs e)
        {
            await productServices.LoadAllProducts(dgvProducts);
            await productServices.LoadCboMarks(cboMarks);
            await productServices.LoadCboAreas(cboRubros);
        }

      

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (validatorServices.ValidateNurlOrEmptyTextboxs(txtNumberProduct, "Nº PRODUCTO"))
            {
                return;
            }

            await productServices.LoadOneProduct(dgvProducts, txtNumberProduct);
        }

        private async void btnAceptRegisterProduct_Click(object sender, EventArgs e)
        {
            if (validatorServices.ValidateNurlOrEmptyTextboxs(txtNameProduct, "NOMBRE"))
            {
                return;
            }

            if (validatorServices.ValidateNurlOrEmptyTextboxs(txtDescription, "DESCRIPCION"))
            {
                return;
            }

            if (validatorServices.ValidateNurlOrEmptyTextboxs(txtPrice, "PRECIO"))
            {
                return;
            }

            if (validatorServices.ValidateNurlOrEmptyTextboxs(txtStock, "STOCK"))
            {
                return;
            }

            if (validatorServices.ValidateNurlOrEmptyTextboxs(txtStockMinimo, "STOCK MINIMO"))
            {
                return;
            }




            await productServices.PostOrder(cboMarks, cboRubros, txtNameProduct, txtDescription, txtPrice, txtStock, txtStockMinimo,dgvProducts);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (validatorServices.ValidateNurlOrEmptyTextboxs(txtDeleteProduct, "Nº PRODUCTO"))
            {
                return;
            }
           

            if (validatorServices.ButtonDeleteClick(sender, e))
            {
                await productServices.DeleteProduct(txtDeleteProduct, dgvProducts);
                txtDeleteProduct.Clear();
            }


         
        }

        private void txtNumberProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumberProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            validatorServices.ValidatorOnlyNumbers(sender, e);
        }

        private void txtDeleteProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            validatorServices.ValidatorOnlyNumbers(sender, e);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            validatorServices.ValidatorOnlyNumbers(sender, e);
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            validatorServices.ValidatorOnlyNumbers(sender, e);
        }

        private void txtStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validatorServices.ValidatorOnlyNumbers(sender, e);
        }
    }
}
