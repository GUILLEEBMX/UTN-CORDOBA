using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2_Programacion_II.Services;

namespace TP2_Programacion_II
{
    public partial class FormInvoice : Form
    {
        private readonly IContextServices context;
        private readonly IFormInvoiceValidatorServices formInvoiceValidator;

        public FormInvoice(IContextServices _context, IFormInvoiceValidatorServices _formInvoiceValidatorServices)
        {
            InitializeComponent();
            context = _context;
            formInvoiceValidator = _formInvoiceValidatorServices;
        }

        private void FormInvoice_Load(object sender, EventArgs e)
        {
            context.NextInvoice(lblNºFactura);
            context.LoaderPaymentMethods(cboPaymentMethod);
            context.LoaderArticles(cboArticle);
        }


        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            formInvoiceValidator.ButtonAddClick(sender, e, cboArticle, txtAmount, detailsDgv);
        }


        private void ButtonAcept_Click(object sender, EventArgs e)
        {
            formInvoiceValidator.ButtonAceptClick(sender, e, txtClient, txtAmount, detailsDgv, cboArticle, cboPaymentMethod);
        }
    }
}
