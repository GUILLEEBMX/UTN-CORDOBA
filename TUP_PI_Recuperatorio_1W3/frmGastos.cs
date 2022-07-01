using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TUP_PI_Recuperatorio_1W3
{
    public partial class frmGastos : Form
    {
        Context context;
        DataTable table;
        public frmGastos()
        {
            InitializeComponent();
            context = new Context();
            table = new DataTable();
        }

        private void frmPlantas_Load(object sender, EventArgs e)
        {

            LoadCBO();
            LoadList();
            EnableOrNotAllCommands(false);
            LoadPaymendMethods();
        
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnableOrNotAllCommands (bool x)
        {
            txtCodigo.Enabled = x;
            txtDia.Enabled = x;
            cboCategoria.Enabled = x;
            cboMedioPago.Enabled = x;
            txtImporte.Enabled = x;
            lstGastos.Enabled = x;
            btnGuardar.Enabled = x;
         

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validators();

            Gasto spent = new Gasto();
            spent.Dia = int.Parse(txtDia.Text);
            spent.Categoria = (int)cboCategoria.SelectedValue;
            spent.MedioPago = (int)cboMedioPago.SelectedIndex;
            spent.Importe = double.Parse(txtImporte.Text);

            List<Parametro> valuesToInsert = new List<Parametro>();

            valuesToInsert.Add(new Parametro("@dia", spent.Dia));

            valuesToInsert.Add(new Parametro("@categoria", spent.Categoria));

            valuesToInsert.Add(new Parametro("@medioPago", spent.MedioPago));

            valuesToInsert.Add(new Parametro("@importe", spent.Importe));


            string query = "INSERT INTO GASTOS Values(@dia, @categoria,@medioPago,@importe)";

            int rowAffecteds = context.PostToSQL(valuesToInsert, query);

            if (rowAffecteds > 0)
            {
                MessageBox.Show("THE INSERTION HAS BEEN SUCCESFULLY");
                EnableOrNotAllCommands(false);
                lstGastos.Items.Clear();
                LoadList();

            }



        }

        private void LoadCBO()
        {
            
            table = context.GetFromSQL("SELECT * FROM CATEGORIAS");
            cboCategoria.DataSource = table;
            cboCategoria.ValueMember = "idCategoria";
            cboCategoria.DisplayMember = "nombreCategorias";

        }


        private void LoadPaymendMethods()
        {

            cboMedioPago.Items.Add("1-EFECTIVO");
            cboMedioPago.Items.Add("2-TARJETA");
            cboMedioPago.Items.Add("3-TRANSFERENCIA");
        

        }


        private void LoadList()
        {
            lstGastos.Items.Clear();

            table = context.GetFromSQL("SELECT * FROM GASTOS ");

            foreach (DataRow row in table.Rows)
            {
                Gasto spent = new Gasto();
                spent.Codigo = (int)row["codigo"];
                spent.Dia = (int)row["dia"];
                spent.Categoria = (int)row["categoria"];
                spent.MedioPago = (int)row["medioPago"];
                spent.Importe = (double)row["importe"];

                lstGastos.Items.Add(spent);

            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            EnableOrNotAllCommands(true);
            txtCodigo.Enabled = false;

        }



        private void cboMedioPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("ONLY NUMBERS");
                e.Handled = true;

            }
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("ONLY NUMBERS");
                e.Handled = true;

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ESTA SEGURO QUE DESEA CERRAR LA APLICACION?", "CLOSE", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }
            else
            {
                return;
            }
        }


        private void Validators()
        {
            int day = int.Parse(txtDia.Text);

            if (day < 1 || day > 31)
            {
                MessageBox.Show("ONLY ALLOWED NUMBERS OF THE MONTH");
                txtDia.Clear();
                txtDia.Focus();
                return;
            }

            if (txtDia.Text.Length == 0 || txtImporte.Text.Length == 0)
            {
                MessageBox.Show("EL CAMPO DIA O EL CAMPO IMPORTE NO PUEDEN ESTAR VACIOS...");
                return;
            }

            if (cboCategoria.SelectedIndex == -1 || cboMedioPago.SelectedIndex == -1)
            {
                MessageBox.Show("DEBE SELECCIONAR AL MENOS UNA CATEGORIA O AL MENOS UN METODO DE PAGO");
                return;
            }
        }

        private void txtDia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
