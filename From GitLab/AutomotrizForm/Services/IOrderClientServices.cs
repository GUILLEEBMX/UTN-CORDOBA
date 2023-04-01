using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizForm.Services
{
    public interface IOrderClientServices
    {
        public Task LoadCboProviders(ComboBox cboProviders);

        public Task LoadCboSubsidiaries(ComboBox cboSubsidiaries);

        public Task LoadCboDeliveries(ComboBox cboDeliveries);

        public Task LoadCboRequestType(ComboBox cboRequestTypes);

        public Task LoadCboEmployees(ComboBox cboEmployees);

        public Task LoadCboClients(ComboBox cboClients);

        public Task LoadCboProducts(ComboBox cboProducts);

        public Task PostOrder (ComboBox cboProviders,ComboBox cboSubsidiaries, ComboBox cboDeliveries, ComboBox cboRequestTypes, ComboBox cboEmployees,ComboBox cboClients,ComboBox cboProducts,DateTimePicker dtpDateOrder,DateTimePicker dtpHourOrder,DateTimePicker dtpDateDeliveryOrder,DateTimePicker dtpPlazoEntregaPedido,TextBox txtPrice, TextBox txtAmount);

        public  Task LoadAllOrders(DataGridView dgvOrders);

        public Task LoadOneOrder(TextBox txtNumberOrder, DataGridView dgvOrders);

    }
}
