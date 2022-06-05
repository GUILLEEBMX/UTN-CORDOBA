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


namespace PROBLEMA_5._3
{
    public partial class Products : Form
    {

        Context context = new Context();
        DataTable table = new DataTable();
        //static string connectionString;
       // connectionString = @"Data Source = .\SQLEXPRESS; Initial Catalog = PRODUCTOS_PROBLEMA_5_3; Integrated Security = True";
        public Products()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool x = true;
            EnableOrNotAllCommands(x);
            LstProducts.Focus();
            LoadCBO();
            PrimaryKeyValues();
            
            
           
        }

        private void TXT_CODIGO_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < PrimaryKeyValues().Length; i++)
            {
                if (TXT_CODIGO.Text.Contains(PrimaryKeyValues()[i].ToString()))
                {
                    if(MessageBox.Show("ESTE CODIGO YA EXISTE EN NUESTRA BD, INGRESA OTRO...") == DialogResult.OK)
                    {
                        TXT_CODIGO.Clear();
                    }
                    
                }
            }
         
        }

       private void EnableOrNotAllCommands(bool x)
        {
            TXT_CODIGO.Enabled = !x;
            TXT_DETALLE.Enabled = !x;
            RDBT_NETBOOK.Enabled = !x;
            RDBT_NOTEBOOK.Enabled = !x;
            RDBT_NETBOOK.Checked = !x ;
            RDBT_NOTEBOOK.Checked = !x;
            cboMarca.Enabled = !x;
            TXT_PRECIO.Enabled = !x;
            DATE_PICKER.Enabled = !x;
            BTN_CANCEL.Enabled = !x;
            BTN_RECORD.Enabled = !x;

        }

        private void Products_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            bool x = false;
            EnableOrNotAllCommands(x);

        }

        private void LoadCBO()
        {
            DataTable table = context.GetFromSQL("Select * from Marcas");
            cboMarca.DataSource = table;
            cboMarca.ValueMember = "idMarca";
            cboMarca.DisplayMember = "nombreMarca";

        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LstProducts.Items.Clear();

            table = context.GetFromSQL("SELECT * FROM PRODUCTOS ");



            foreach (DataRow row in table.Rows)
            {
                Productos product = new Productos();
                product.Codigo = (int)row["codigo"];
                product.Detalle = row["detalle"].ToString();
                product.Tipo = (int)row["tipo"];
                product.Marca = (int)row["marca"];
                product.Precio = (double)row["precio"];
                product.Fecha = (DateTime)row["fecha"];

                LstProducts.Items.Add(product);

            }

        }

        private int [] PrimaryKeyValues()
        {
            int[] primaryKeys = new int [table.Rows.Count];

            table = context.GetFromSQL("SELECT * FROM Productos");

            for (int i = 0; i < primaryKeys.Length; i++)
            {
                primaryKeys[i] = (int)table.Rows[i].ItemArray[0];

            }

            return primaryKeys;



        }

        private void BTN_RECORD_Click(object sender, EventArgs e)
        {
            int tipo = 0;

            int rowAffecteds = 0;
          
            if (!RDBT_NETBOOK.Checked)
            {
                tipo = 1;
            }


            Productos product = new Productos();
            product.Codigo = int.Parse(TXT_CODIGO.Text);
            product.Detalle = TXT_DETALLE.Text;
            product.Marca = 1;
            product.Tipo = tipo;
            product.Precio = double.Parse(TXT_PRECIO.Text);
            product.Fecha = DATE_PICKER.Value;

          

            string query = "INSERT INTO PRODUCTOS Values(@codigo,@detalle,@tipo,@marca, @precio,@fecha)";


            Parametro values = new Parametro();
            
            values.param = new object[6];


            values.param[0] = ("@codigo", product.Codigo);

            values.param[1] = ("@detalle", product.Detalle);

            values.param[2] = ("@marca", product.Marca);

            values.param[3] = ("@tipo", product.Tipo);

            values.param[4] = ("@precio", product.Precio);

            values.param [5] = ("@fecha", product.Fecha);

            rowAffecteds = context.PostToSQL(query, values);



            if (rowAffecteds != 0)
            {
                if (MessageBox.Show("LA INSERCION SE REALIZO CORRECTAMENTE CULEAUUUU") == DialogResult.OK)
                {

                    EmptyAllCommands();
                }


            }



        }

        private void EmptyAllCommands()
        {
            TXT_CODIGO.Clear();
            TXT_DETALLE.Clear();
            RDBT_NETBOOK.Checked = false;
            RDBT_NOTEBOOK.Checked = false;
            TXT_PRECIO.Clear();
        }


    }
}
