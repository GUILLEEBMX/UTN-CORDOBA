using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2_Programacion_II.Models;
using TP2_Programacion_II.Services;

namespace TP2_Programacion_II.Validators
{
    class FormInvoiceValidator : IFormInvoiceValidatorServices
    {
        private readonly Context context;
        private readonly InvoiceModel invoice;
        private readonly DetailInvoice detailInvoice;
        private readonly IInvoiceServices invoiceServices;

        public FormInvoiceValidator(InvoiceModel _invoiceModel, Context _context, IInvoiceServices _invoiceServices, DetailInvoice _detailInvoice)
        {
            invoice = _invoiceModel;
            context = _context;
            detailInvoice = _detailInvoice;


            invoiceServices = _invoiceServices;


        }


        public void ButtonAddClick(object sender, EventArgs e, ComboBox cboProducts, TextBox txtAmount, DataGridView detailsDgv)
        {
            if (cboProducts.Text.Equals(String.Empty))
            {
                MessageBox.Show("You should select one Product", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtAmount.Text == "" || !int.TryParse(txtAmount.Text, out _))
            {
                MessageBox.Show("Should select an amount valid!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //foreach (DataGridViewRow row in detailsDgv.Rows)
            //{
            //    if (row.Cells["Products"].Value.ToString().Equals(cboProducts.Text))
            //    {
            //        MessageBox.Show("PRODUCTO: " + cboProducts.Text + "ya se encuentra como detalle!", "Control",

            //        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        return;
            //    }
            //}
            DataRowView item = (DataRowView)cboProducts.SelectedItem;
            detailsDgv.Rows.Add(new object[] { item.Row.ItemArray[0], item.Row.ItemArray[1], item.Row.ItemArray[2], txtAmount.Text });

        }

        public void ButtonAceptClick(object sender, EventArgs e, TextBox txtClient, TextBox txtAmount, DataGridView detailsDgv, ComboBox cboArticles, ComboBox cboPaymentMethod)
        {
            if (txtClient.Text == "")
            {
                MessageBox.Show("Should select a client", "Control",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (detailsDgv.Rows.Count == 0)
            {
                MessageBox.Show("Should select a one Detail", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            SaveInvoice(txtClient, txtAmount, cboPaymentMethod, cboArticles);


        }

        public void SaveInvoice(TextBox txtClient, TextBox txtAmount, ComboBox cboPaymentMethod, ComboBox cboArticles)
        {
            invoice.Client = txtClient.Text;
            invoice.PaymentMethod = (int)cboPaymentMethod.SelectedIndex + 1;
            invoice.Date = DateTime.Now;
            DataRowView item = (DataRowView)cboArticles.SelectedItem;
            int article = Convert.ToInt32(item.Row.ItemArray[0]);
            int amount = Convert.ToInt32(txtAmount.Text);
            string name = item.Row.ItemArray[1].ToString();
            double price = Convert.ToDouble(item.Row.ItemArray[2]);
            Article _article = new Article();
            _article.Id = article;
            _article.Name = name;
            _article.UnitPrice = price;
            detailInvoice.Amount = amount;
            detailInvoice.Article = _article;

            invoice.AddDetail(detailInvoice);

            if (context.PostToDatabase(invoice))
            {
                MessageBox.Show("Invoice Registered", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR. The invoice has not been registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ButtonCancelClick(object sender, EventArgs e, Application application)
        {
            if (MessageBox.Show("Are you really close the app?") == DialogResult.OK)
            {

            }
        }


    }
}
