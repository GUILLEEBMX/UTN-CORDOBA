using System;
using System.Data;
using System.Windows.Forms;
using TP2_Programacion_II.Services;


namespace TP2_Programacion_II
{
    public partial class FormInvoice : Form
    {
        private readonly IBudgetRepositoryServices budgetRepository;
        private readonly IFormInvoiceValidatorServices formInvoiceValidator;
        Context context = Context.GetInstance();

       

        public FormInvoice(IBudgetRepositoryServices _budgetRepositoryServices, IFormInvoiceValidatorServices _formInvoiceValidatorServices)
        {
            InitializeComponent();
            budgetRepository = _budgetRepositoryServices;
            formInvoiceValidator = _formInvoiceValidatorServices;
        }

        private void FormInvoice_Load(object sender, EventArgs e)
        {
            budgetRepository.NextInvoice(lblNºFactura);
            budgetRepository.LoaderPaymentMethods(cboPaymentMethod);
            budgetRepository.LoaderArticles(cboArticle);

           
            

            DataTable table = new DataTable();

            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("BudgetDataSet",table));


            this.reportViewer1.RefreshReport();
        }


        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            formInvoiceValidator.ButtonAddClick(sender, e, cboArticle, txtAmount, detailsDgv);
        }


        private void ButtonAcept_Click(object sender, EventArgs e)
        {
            formInvoiceValidator.ButtonAceptClick(sender, e, txtClient, txtAmount, detailsDgv, cboArticle, cboPaymentMethod);
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            formInvoiceValidator.ValidatorOnlyNumbers(sender, e);
        }

        private void txtDelete_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //budgetRepository.DeleteFromDataBase(txtDelete);
            
        }

        private void txtDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            formInvoiceValidator.ValidatorOnlyNumbers(sender, e);
        }

      
    }
}
