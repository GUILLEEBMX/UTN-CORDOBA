using API_Automotriz.Services;
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
    public partial class ListOrdersForm : Form
    {

        private readonly IOrderClientServices orderServices;
        private readonly IValidatorServices validatorServices;
        public ListOrdersForm(IOrderClientServices orderServices, IValidatorServices validatorServices)
        {
            InitializeComponent();
            this.orderServices = orderServices;
            this.validatorServices = validatorServices;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void ListOrdersForm_Load(object sender, EventArgs e)
        {
            await orderServices.LoadAllOrders(dgvOrders);


        }


        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (validatorServices.ValidateNurlOrEmptyTextboxs(txtNumberOrder, "Nº PEDIDO"))
            {
                return;
            }

            await orderServices.LoadOneOrder(txtNumberOrder,dgvOrders);
        }

        private void txtNumberOrder_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNumberOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            validatorServices.ValidatorOnlyNumbers(sender, e);
        }
    }
}
