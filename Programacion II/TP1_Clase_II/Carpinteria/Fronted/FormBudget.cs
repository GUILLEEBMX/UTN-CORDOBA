using Carpinteria.Context;
using Carpinteria.Domain;
using Carpinteria.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace Carpinteria.Fronted
{
    public partial class FormBudget : Form
    {
      
        private readonly IContextService context;
        private readonly IFormBudgetValidatorService formBudgetServices;
        
        public FormBudget(IContextService service,IFormBudgetValidatorService _formBudgetServices)
        {
            InitializeComponent();
            context = service;
            formBudgetServices = _formBudgetServices;
            
        }
        private void FormBudget_Load(object sender, EventArgs e)
        {
            context.NextBudget(lblNumberBudget);
            context.LoaderCbo(cboProducts);
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            formBudgetServices.ButtonAddClick(sender, e, cboProducts, txtAmount,detailsDgv);
        }

        private void ButtonAcept_Click(object sender, EventArgs e)
        {
            formBudgetServices.ButtonAceptClick(sender, e, txtClient, detailsDgv,txtDiscount);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {

        }

        private void detailsDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

