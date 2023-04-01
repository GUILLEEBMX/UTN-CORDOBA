using AutomotrizForm.Services;
using AutomotrizLibrary;
using AutomotrizLibrary.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizForm.Fronted
{
    public partial class OrderForm : Form
    {
        private readonly ListOrdersForm listOrders;
        private readonly IOrderClientServices orderServices;
        private readonly IValidatorServices validatorServices;
        public OrderForm(ListOrdersForm listOrders,IOrderClientServices orderServices,IValidatorServices validatorServices)
        {
            InitializeComponent();
            this.listOrders = listOrders;
            this.orderServices = orderServices;
            this.validatorServices = validatorServices;
           
        }

        
        private async void OrderForm_Load(object sender, EventArgs e)
        {
            await orderServices.LoadCboProviders(cboProviders);
            await orderServices.LoadCboSubsidiaries(cboSubsidiaries);
            await orderServices.LoadCboRequestType(cboRequestTypes);
            await orderServices.LoadCboEmployees(cboEmployees);
            await orderServices.LoadCboDeliveries(cboDeliveries);
            await orderServices.LoadCboClients(cboClients);
            await orderServices.LoadCboProducts(cboProducts);

        }


        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private async  void btnRegistrarPedido_Click(object sender, EventArgs e)
        {
            if (validatorServices.ValidateNurlOrEmptyTextboxs(txtPrice, "PRECIO"))
            {
                return;
            }

            if (validatorServices.ValidateNurlOrEmptyTextboxs(txtAmount, "CANTIDAD"))
            {
                return;
            }

            await orderServices.PostOrder(cboProviders,cboSubsidiaries,cboDeliveries,cboRequestTypes,cboEmployees,cboClients,cboProducts,dtpDateOrder, dtpOrderHour,dtpDateDeliveryOrder,dtpPlazoEntregaPedido,txtPrice,txtAmount);




        }


        private void btnGetAllOrders_Click(object sender, EventArgs e)
        {
            listOrders.ShowDialog();
            
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            validatorServices.ValidatorOnlyNumbers(sender, e);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            validatorServices.ValidatorOnlyNumbers(sender, e);
        }
    }
}
