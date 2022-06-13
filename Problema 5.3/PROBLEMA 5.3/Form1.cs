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
           
        }

        private void TXT_CODIGO_TextChanged(object sender, EventArgs e)
        {
            

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
            int tipo = 0;
            TXT_CODIGO.Enabled = false;

            if (LstProducts.SelectedIndex != -1)
            {
                Productos product = (Productos)LstProducts.SelectedItem;
                TXT_CODIGO.Text = product.Codigo.ToString();
                TXT_DETALLE.Text = product.Detalle;
                cboMarca.SelectedValue = product.Marca;
                tipo = product.Tipo;
                TXT_PRECIO.Text = product.Precio.ToString();
                DATE_PICKER.Value = product.Fecha;
               
              

            }



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
            if(MessageBox.Show("¿ESTA SEGURO QUE DESEA CERRAR LA APLICACION?","CLOSE", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }
            else
            {
                return;
            }




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

       

        private void BTN_RECORD_Click(object sender, EventArgs e)
        {
            int tipo = 0;

            int rowAffecteds = 0;

            if (!RDBT_NETBOOK.Checked)
            {
                tipo = 1;
            }

            

            if (LstProducts.SelectedIndex != -1)
            {
                TXT_CODIGO.Enabled = false;

                Productos product = (Productos)LstProducts.SelectedItem;
                product.Codigo = int.Parse(TXT_CODIGO.Text);
                product.Detalle = TXT_DETALLE.Text;
                product.Marca = (int)cboMarca.SelectedValue;
                product.Tipo = tipo;
                product.Precio = int.Parse(TXT_PRECIO.Text);
                product.Fecha = DATE_PICKER.Value;

                string updateQuery = "UPDATE Productos SET detalle=@detalle,tipo = @tipo,marca = @marca,precio = @precio,fecha = @fecha WHERE codigo = @codigo";
                //string updateQuery = "UPDATE Productos SET @detalle=detalle,@tipo = tipo,@marca = marca,@precio = precio,@fecha = fecha WHERE @codigo = codigo";
                //EL @ debe estar del lado derecho de la asignacion...


                List<Parametro> valuesToInsert = new List<Parametro>();


                valuesToInsert.Add(new Parametro("@codigo", product.Codigo));

                valuesToInsert.Add(new Parametro("@detalle", product.Detalle));

                valuesToInsert.Add(new Parametro("@marca", product.Marca));

                valuesToInsert.Add(new Parametro("@tipo", product.Tipo));

                valuesToInsert.Add(new Parametro("@precio", product.Precio));

                valuesToInsert.Add(new Parametro("@fecha", product.Fecha));

                rowAffecteds = context.PostToSQL(updateQuery, valuesToInsert);

                if (rowAffecteds != 0)
                {
                    if (MessageBox.Show("LA ACTUALIZACION SE REALIZO CORRECTAMENTE...") == DialogResult.OK)
                    {

                        EmptyAllCommands();
                        LstProducts.Items.Clear();
                        LoadList();
                        
                    }

                }


            }

            else
            {

            int codigo = int.Parse(TXT_CODIGO.Text);


            for (int i = 0; i < context.PrimaryKeyValues().Length; i++)
            {
                if (codigo == context.PrimaryKeyValues()[i])
                {
                    if (MessageBox.Show("ESE CODIGO YA EXISTE EN NUESTRA BD... ELIGE OTRO...") == DialogResult.OK)
                    {
                        TXT_CODIGO.Clear();
                        return;
                    }

                }

            }

           
           Productos product = new Productos();

            product.Codigo = int.Parse(TXT_CODIGO.Text);
            product.Detalle = TXT_DETALLE.Text;
            product.Marca = (int)cboMarca.SelectedValue;
            product.Tipo = tipo;
            product.Precio = double.Parse(TXT_PRECIO.Text);
            product.Fecha = DATE_PICKER.Value;


            string query = "INSERT INTO PRODUCTOS Values(@codigo,@detalle,@tipo,@marca, @precio,@fecha)";


            List<Parametro> valuesToInsert = new List<Parametro>();


            valuesToInsert.Add(new Parametro("@codigo", product.Codigo));

            valuesToInsert.Add(new Parametro("@detalle", product.Detalle));

            valuesToInsert.Add(new Parametro("@marca", product.Marca));

            valuesToInsert.Add(new Parametro("@tipo", product.Tipo));

            valuesToInsert.Add(new Parametro ("@precio", product.Precio));

            valuesToInsert.Add(new Parametro("@fecha", product.Fecha));

            rowAffecteds = context.PostToSQL(query, valuesToInsert);

            if (rowAffecteds != 0)
            {
                if (MessageBox.Show("LA INSERCION SE REALIZO CORRECTAMENTE...") == DialogResult.OK)
                {

                    EmptyAllCommands();
                    LstProducts.Items.Clear();
                    LoadList();
                }

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (LstProducts.SelectedIndex == -1)
            {
                MessageBox.Show("DEBE SELECCIONAR AL MENOS UN PRODUCTO...");
                
            }

            else
            {
                int rowAffecteds = 0;
                if (LstProducts.SelectedIndex != -1)
                {
                    if (MessageBox.Show("¿ESTA SEGURO QUE DESEA ELIMINAR?","ELIMINAR",MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        var producto = (Productos)LstProducts.SelectedItem;

                        rowAffecteds = context.DeleteFromDB(producto.Codigo, "Productos");
                    }
                    else
                    {
                        return;
                    }
                }

                if (rowAffecteds > 0)
                {
                    if (MessageBox.Show("SE HA ELIMINADO CORRECTAMENTE...") == DialogResult.OK)
                    {
                        LstProducts.Items.Clear();
                    }
                }

                LoadList();

            }
        }

        private void TXT_CODIGO_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("ONLY NUMBERS...");
                e.Handled = true;
            }    
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            EmptyAllCommands();
        }

        private void TXT_PRECIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("ONLY NUMBERS...");
                e.Handled = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void LoadList()
        {
            
            table = context.GetFromSQL("SELECT * FROM PRODUCTOS");

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

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }






}
