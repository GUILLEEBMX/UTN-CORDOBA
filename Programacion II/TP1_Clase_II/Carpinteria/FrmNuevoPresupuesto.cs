using Carpinteria1w4.AccesoDatos;
using Carpinteria1w4.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpinteria1w4.Presentacion
{
    public partial class FrmNuevoPresupuesto : Form
    {
        Presupuesto oPresupuesto;
        DBHelper oDatos;
        public FrmNuevoPresupuesto()
        {
            InitializeComponent();
            oPresupuesto = new Presupuesto();
            oDatos = new DBHelper();
        }

        private void FrmNuevoPresupuesto_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txtCliente.Text = "Consumidor Final";
            txtDescuento.Text = "0";
            txtCantidad.Text = "1";
            CargarProductos();
            lblNroPresupuesto.Text += ProximoPresupuesto();
        }

        private void CargarProductos()
        {
            DataTable Tabla = new DataTable();
            Tabla=oDatos.ConsultarDB("SP_CONSULTAR_PRODUCTOS");
            cboProductos.DataSource = Tabla;
            cboProductos.ValueMember = Tabla.Columns[0].ColumnName;
            cboProductos.DisplayMember = Tabla.Columns[1].ColumnName;
        }
    }
}
