using Carpinteria.Context;
using Carpinteria.Domain;
using Carpinteria.Fronted;
using Carpinteria.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpinteria.Validators
{
    public class FormBudgetValidator : IFormBudgetValidatorService
    {
        private readonly Entity context;
        private readonly Budget budget;

        public FormBudgetValidator(Budget _budget, Entity _context)
        {
            budget = _budget;
            context = _context;


        }


        public void ButtonAddClick(object sender, EventArgs e, ComboBox cboProducts, TextBox txtAmount,DataGridView detailsDgv)
        {
            if (cboProducts.Text.Equals(String.Empty))
            {
                MessageBox.Show("You should select one Product", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtAmount.Text == "" || !int.TryParse(txtAmount.Text, out _))
            {
                MessageBox.Show("Should select an amount valid!","Control", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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
            //int product = Convert.ToInt32(item.Row.ItemArray[0]);
            //string name = item.Row.ItemArray[1].ToString();
            //double price = Convert.ToDouble(item.Row.ItemArray[2]);
            Product _product = new Product();
            int amount = Convert.ToInt32(txtAmount.Text);
            DetailBudget detailBudget = new DetailBudget(amount, _product);
            Budget budget = new Budget();
            budget.AddDetail(detailBudget);
            detailsDgv.Rows.Add(new object[] { item.Row.ItemArray[0], item.Row.ItemArray[1], item.Row.ItemArray[2], txtAmount.Text });
            budget.CalculateTotal();

        }

        public void ButtonAceptClick(object sender, EventArgs e, TextBox txtClient, DataGridView detailsDgv,TextBox txtDiscount)
        {
            if (txtClient.Text == "")
            {
                MessageBox.Show("Should select a client", "Control",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (detailsDgv.Rows.Count == 0)
            {
                MessageBox.Show("Should select a one Detail","Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            SaveBudget(txtClient, txtDiscount) ;


        }

        public void SaveBudget(TextBox txtClient, TextBox txtDiscount)
        {
            budget.Client = txtClient.Text;
            budget.Discount = Convert.ToDouble(txtDiscount.Text);
            budget.HighDate = DateTime.Now;
            if (context.PostToDatabase(budget))
            {
                MessageBox.Show("Budget Registered", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR. The budget has not been registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ButtonCancelClick(object sender, EventArgs e, Application application)
        {
            if(MessageBox.Show("Are you really close the app?") == DialogResult.OK)
            {
              
            }
        }




    }
}
