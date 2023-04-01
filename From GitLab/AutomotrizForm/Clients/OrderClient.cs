using API_Automotriz.Services;
using AutomotrizForm.Services;
using AutomotrizLibrary;
using AutomotrizLibrary.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizForm.Clients
{
    public class OrderClient : IOrderClientServices 
    {
        private readonly HttpClient request;
        private readonly OrderPostDTO order;
        private readonly OrderDetailDTO orderDetail;
        public OrderClient(HttpClient request, OrderPostDTO order, OrderDetailDTO orderDetail)
        {
            this.request = request;
            this.order = order;
            this.orderDetail = orderDetail;
        }
        public async Task LoadCboProviders(ComboBox cboProviders)
        {

            string url = "https://localhost:5001/providers";
            var result = await request.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            var lst = JsonConvert.DeserializeObject<List<Object>>(content);
            cboProviders.DataSource = lst;
            cboProviders.DisplayMember = "nombre";
            cboProviders.ValueMember = "id";
            //cboProviders.DisplayMember = "id";
            //cboProviders.ValueMember = "nombre";

        }

        public async Task LoadCboSubsidiaries(ComboBox cboSubsidiaries)
        {

            HttpClient client = new HttpClient();
            string url = "https://localhost:5001/subsidiaries";
            var result = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            var lst = JsonConvert.DeserializeObject<List<Object>>(content);
            cboSubsidiaries.DataSource = lst;
            cboSubsidiaries.DisplayMember = "direccionSucursal";
            cboSubsidiaries.ValueMember = "idSucursal";
            //cboSubsidiaries.DisplayMember = "idSucursal";
            //cboSubsidiaries.ValueMember = "direccionSucursal";

        }

        public async Task LoadCboDeliveries(ComboBox cboDeliveries)
        {

            HttpClient client = new HttpClient();
            string url = "https://localhost:5001/deliveries";
            var result = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            var lst = JsonConvert.DeserializeObject<List<Object>>(content);
            cboDeliveries.DataSource = lst;
            cboDeliveries.DisplayMember = "descripcion";
            cboDeliveries.ValueMember = "iD_ENTREGA";

            //cboDeliveries.DisplayMember = "iD_ENTREGA";
            //cboDeliveries.ValueMember = "descripcion";

        }

        public async Task LoadCboRequestType(ComboBox cboRequestTypes)
        {

            HttpClient client = new HttpClient();

            string url = "https://localhost:5001/requestType";
            var result = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            var lst = JsonConvert.DeserializeObject<List<Object>>(content);
            cboRequestTypes.DataSource = lst;
            cboRequestTypes.DisplayMember = "viaSolicitud";
            cboRequestTypes.ValueMember = "idSolicitud";

            //cboRequestTypes.DisplayMember = "idSolicitud";
            //cboRequestTypes.ValueMember = "viaSolicitud";

        }

        public async Task LoadCboEmployees(ComboBox cboEmployees)
        {

            HttpClient client = new HttpClient();

            string url = "https://localhost:5001/employees";
            var result = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            var lst = JsonConvert.DeserializeObject<List<Object>>(content);
            cboEmployees.DataSource = lst;
            cboEmployees.DisplayMember = "nombre";
            cboEmployees.ValueMember = "idEmpleado";


        }

        public async Task LoadCboClients(ComboBox cboClients)
        {

            HttpClient client = new HttpClient();

            string url = "https://localhost:5001/clients";
            var result = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            var lst = JsonConvert.DeserializeObject<List<Object>>(content);
            cboClients.DataSource = lst;
            cboClients.DisplayMember = "nombre";
            cboClients.ValueMember = "idCliente";


        }

        public async Task LoadCboProducts(ComboBox cboProducts)
        {
            HttpClient client = new HttpClient();


            string url = "https://localhost:5001/products";
            var result = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            var lst = JsonConvert.DeserializeObject<List<Object>>(content);
            cboProducts.DataSource = lst;
            cboProducts.DisplayMember = "nombre";
            cboProducts.ValueMember = "idProducto";

        }

        public async Task PostOrder(ComboBox cboProviders, ComboBox cboSubsidiaries,ComboBox cboDeliveries, ComboBox cboRequestTypes, ComboBox cboEmployees, ComboBox cboClients,ComboBox cboProducts,DateTimePicker dtpDateOrder, DateTimePicker dtpHourOrder, DateTimePicker dtpDateDeliveryOrder,DateTimePicker dtpPlazoEntregaPedido, TextBox txtPrice, TextBox txtAmount)
        {

            order.IdProveedor = int.Parse(cboProviders.SelectedValue.ToString());
            order.IdSucursal = int.Parse(cboSubsidiaries.SelectedValue.ToString());
            order.IdEntrega = int.Parse(cboDeliveries.SelectedValue.ToString());
            order.IdTipoSolicitud = int.Parse(cboRequestTypes.SelectedValue.ToString());
            order.IdEmpleadoReceptor = int.Parse(cboEmployees.SelectedValue.ToString());
            order.FechaPedido = dtpDateOrder.Value;
            order.HoraPedido = dtpHourOrder.Value;
            order.FechaEntregaPedido = dtpDateDeliveryOrder.Value;
            order.PlazoEntregaPedido = dtpPlazoEntregaPedido.Value;
            order.Cliente = int.Parse(cboClients.SelectedValue.ToString());

            orderDetail.IdProducto = int.Parse(cboProducts.SelectedValue.ToString());
            orderDetail.Cantidad = int.Parse(txtAmount.Text);
            orderDetail.PrecioCompra = int.Parse(txtPrice.Text);
            order.OrderDetails.Add(orderDetail);

            string bodyContent = JsonConvert.SerializeObject(order);


            string url = "https://localhost:5001/registerOrder";

            var response = "";
            StringContent content = new StringContent(bodyContent, Encoding.UTF8, "application/json");
            var result = await request.PostAsync(url, content);
            response = await result.Content.ReadAsStringAsync();
            if (result.IsSuccessStatusCode)
            {
             
                if (MessageBox.Show(response) == DialogResult.OK)
                {
                    cboProviders.SelectedIndex = -1;
                    cboProducts.SelectedIndex = -1;
                    cboClients.SelectedIndex = -1;
                    cboDeliveries.SelectedIndex = -1;
                    cboEmployees.SelectedIndex = -1;
                    cboRequestTypes.SelectedIndex = -1;
                    cboSubsidiaries.SelectedIndex = -1;
                    txtAmount.Clear();
                    txtPrice.Clear();
                }

            }

            else
            {
               
                MessageBox.Show(response);
            }

        }

        public async Task LoadAllOrders(DataGridView dgvOrders)
        {



            string url = "https://localhost:5001/orders";
            var result = await request.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            var lst = JsonConvert.DeserializeObject<List<Order>>(content);

            dgvOrders.RowCount = lst.Count;

            for (int i = 0; i < dgvOrders.RowCount; i++)
            {
                dgvOrders.Rows[i].Cells[0].Value = lst[i].IdPedido;
                dgvOrders.Rows[i].Cells[1].Value = lst[i].IdProveedor;
                dgvOrders.Rows[i].Cells[2].Value = lst[i].IdSucursal;
                dgvOrders.Rows[i].Cells[3].Value = lst[i].IdEntrega;
                dgvOrders.Rows[i].Cells[4].Value = lst[i].IdTipoSolicitud;
                dgvOrders.Rows[i].Cells[5].Value = lst[i].IdEmpleadoReceptor;
                dgvOrders.Rows[i].Cells[6].Value = lst[i].FechaPedido;
                dgvOrders.Rows[i].Cells[7].Value = lst[i].HoraPedido;
                dgvOrders.Rows[i].Cells[8].Value = lst[i].FechaEntregaPedido;
                dgvOrders.Rows[i].Cells[9].Value = lst[i].PlazoEntregaPedido;
                dgvOrders.Rows[i].Cells[10].Value = lst[i].Cliente;

            }

        }

        public async Task LoadOneOrder(TextBox txtNumberOrder,DataGridView dgvOrders)
        {

            string url = "https://localhost:5001/api/Order/" + txtNumberOrder.Text;
            var result = await request.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            var lst = JsonConvert.DeserializeObject<Order>(content);

            dgvOrders.RowCount = 1;

            for (int i = 0; i < dgvOrders.RowCount; i++)
            {
                dgvOrders.Rows[i].Cells[0].Value = lst.IdPedido;
                dgvOrders.Rows[i].Cells[1].Value = lst.IdProveedor;
                dgvOrders.Rows[i].Cells[2].Value = lst.IdSucursal;
                dgvOrders.Rows[i].Cells[3].Value = lst.IdEntrega;
                dgvOrders.Rows[i].Cells[4].Value = lst.IdTipoSolicitud;
                dgvOrders.Rows[i].Cells[5].Value = lst.IdEmpleadoReceptor;
                dgvOrders.Rows[i].Cells[6].Value = lst.FechaPedido;
                dgvOrders.Rows[i].Cells[7].Value = lst.HoraPedido;
                dgvOrders.Rows[i].Cells[8].Value = lst.FechaEntregaPedido;
                dgvOrders.Rows[i].Cells[9].Value = lst.PlazoEntregaPedido;
                dgvOrders.Rows[i].Cells[10].Value = lst.Cliente;

            }

        }



    }
}
