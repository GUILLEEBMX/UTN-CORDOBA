using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_Programacion_II
{
    public partial class Form1 : Form
    {
        private Context context;

        public Form1()
        {
            InitializeComponent();
            context = new Context();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCBO();

        }

        private void LoadCBO()
        {
            DataTable table = new DataTable();

            table = context.GetFromDatabase("SELECT * FROM FORMAS_PAGOS");
            cboFormaPago.DataSource = table;
            cboFormaPago.ValueMember = "idFormaPago";
            cboFormaPago.DisplayMember = "nombre";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Factura factura = new Factura();
            //DetalleFactura detalleFactura = new DetalleFactura();
            //factura.Fecha = dateTimePicker1.Value;
            //factura.FormaPago = cboFormaPago.SelectedIndex;
            //factura.Cliente = txtCliente.Text;
            //detalleFactura.Cantidad = int.Parse(txtCantidad.Text);
            //detalleFactura.Articulo.Nombre = txtArticulo.Text;
            //factura.DetalleFactura = detalleFactura;

            Factura factura = new Factura();
            factura.Fecha = dateTimePicker1.Value;
            factura.FormaPago = cboFormaPago.SelectedIndex;
            factura.Cliente = "Guillee Britos";




            string query = "INSERT INTO FACTURAS VALUES (@fecha,@formaPago,@cliente)";



            List<Parameter> valuesToInsert = new List<Parameter>();

            valuesToInsert.Add(new Parameter("@fecha", factura.Fecha));
            valuesToInsert.Add(new Parameter("@formaPago", factura.FormaPago));
            valuesToInsert.Add(new Parameter("@cliente", factura.Cliente));

            int rowAffecteds = context.PostToDatabase(query, valuesToInsert);

            if(rowAffecteds > 0)
            {
                MessageBox.Show("THE INSERTION HAS SUCCESSFULLY...");
                
            }



        }
    }
}
