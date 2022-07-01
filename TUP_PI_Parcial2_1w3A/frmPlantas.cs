using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUP_PI_Parcial2_13A;
using static TUP_PI_Parcial2_13A.Context;

//CURSO: – LEGAJO: – APELLIDO: – NOMBRE:
//Cadena de Conexión: "Data Source=138.99.7.66,1433;Initial Catalog=TUPI_Vivero;User ID=tup1_vivero;Password=@tup1_Vive"

namespace TUP_PI_Parcial2_1w3A
{
    public partial class frmPlantas : Form
    {
        Context context;
        DataTable table;
        public frmPlantas()
        {
            InitializeComponent();
            context = new Context();
            table = new DataTable();
        }

        private void frmPlantas_Load(object sender, EventArgs e)
        {
            LoadList();
            LoadCBO();
            EmptyAllCommands();
            EnableOrNotAllCommands(false);
            BTN_NEW.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            int codigo = int.Parse(txtCodigo.Text);


            for (int i = 0; i < context.PrimaryKeyValues().Length; i++)
            {
                if (codigo == context.PrimaryKeyValues()[i])
                {
                    if (MessageBox.Show("ESE CODIGO YA EXISTE EN NUESTRA BD... ELIGE OTRO...") == DialogResult.OK)
                    {
                        txtCodigo.Clear();
                        return;
                    }

                }

            }


            Planta plant = new Planta();

            plant.Codigo = int.Parse(txtCodigo.Text);
            plant.Nombre = txtNombre.Text;
            plant.Especie = (int)cboEspecie.SelectedValue;
            plant.Precio = double.Parse(txtPrecio.Text);
            plant.Fecha = dtpFecha.Value;


            string query = "INSERT INTO PLANTAS Values(@codigo,@nombre,@especie,@precio,@fecha)";


            List<Parametro> valuesToInsert = new List<Parametro>();


            valuesToInsert.Add(new Parametro("@codigo", plant.Codigo));

            valuesToInsert.Add(new Parametro("@nombre", plant.Nombre));

            valuesToInsert.Add(new Parametro("@especie", plant.Especie));

            valuesToInsert.Add(new Parametro("@precio", plant.Precio));

            valuesToInsert.Add(new Parametro("@fecha", plant.Fecha));

           int  rowAffecteds = context.PostToSQL(query, valuesToInsert);

            if (rowAffecteds != 0)
            {
                if (MessageBox.Show("LA INSERCION SE REALIZO CORRECTAMENTE...") == DialogResult.OK)
                {

                    EnableOrNotAllCommands(false);
                    lstPlantas.Items.Clear();
                    LoadList();
                }

            }

        }

        private void LoadList()
        {

            table = context.GetFromSQL("SELECT * FROM PLANTAS");

            foreach (DataRow row in table.Rows)
            {
                Planta plant = new Planta();
                plant.Codigo = (int)row["codigo"];
                plant.Nombre = row["nombre"].ToString();
                plant.Especie = (int)row["especie"];
                plant.Precio = (double)row["precio"];
                plant.Fecha = (DateTime)row["fecha"];

                lstPlantas.Items.Add(plant);

            }


        }

        private void LoadCBO()
        {
            DataTable table = context.GetFromSQL("SELECT * FROM ESPECIES");
            cboEspecie.DataSource = table;
            cboEspecie.ValueMember = "idEspecie";
            cboEspecie.DisplayMember = "nombreEspecie";

        }

        private void lstPlantas_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            txtCodigo.Enabled = false;

            if (lstPlantas.SelectedIndex != -1)
            {
                Planta plant = (Planta)lstPlantas.SelectedItem;
                txtCodigo.Text = plant.Codigo.ToString();
                txtNombre.Text = plant.Nombre;
                cboEspecie.SelectedValue = plant.Especie;
                txtPrecio.Text = plant.Precio.ToString();
                dtpFecha.Value = plant.Fecha;


            }
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            if (lstPlantas.SelectedIndex != -1)
            {
                txtCodigo.Enabled = false;

                Planta plant = (Planta)lstPlantas.SelectedItem;
                plant.Codigo = int.Parse(txtCodigo.Text);
                plant.Nombre = txtNombre.Text;
                plant.Especie = (int)cboEspecie.SelectedValue;
                plant.Precio = int.Parse(txtPrecio.Text);
                plant.Fecha = dtpFecha.Value;

                string updateQuery = "UPDATE PLANTAS SET nombre=@nombre,especie = @especie,precio = @precio,fecha = @fecha WHERE codigo = @codigo";
                //string updateQuery = "UPDATE Productos SET @detalle=detalle,@tipo = tipo,@marca = marca,@precio = precio,@fecha = fecha WHERE @codigo = codigo";
                //EL @ debe estar del lado derecho de la asignacion...


                List<Parametro> valuesToInsert = new List<Parametro>();


                valuesToInsert.Add(new Parametro("@codigo", plant.Codigo));

                valuesToInsert.Add(new Parametro("@nombre", plant.Nombre));

                valuesToInsert.Add(new Parametro("@especie", plant.Especie));

                valuesToInsert.Add(new Parametro("@precio", plant.Precio));

                valuesToInsert.Add(new Parametro("@fecha", plant.Fecha));

                int rowAffecteds = context.PostToSQL(updateQuery, valuesToInsert);

                if (rowAffecteds != 0)
                {
                    if (MessageBox.Show("LA ACTUALIZACION SE REALIZO CORRECTAMENTE...") == DialogResult.OK)
                    {

                        EmptyAllCommands();
                        lstPlantas.Items.Clear();
                        LoadList();

                    }

                }


            }
        }

        private void EmptyAllCommands()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
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

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("ONLY NUMBERS...");
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("ONLY NUMBERS...");
                e.Handled = true;
            }
        }


        private void EnableOrNotAllCommands(bool x)
        {
            txtCodigo.Enabled = x;
            txtNombre.Enabled = x;
            cboEspecie.Enabled = x;
            txtPrecio.Enabled = x;
            dtpFecha.Enabled = x;
            btnGuardar.Enabled = x;
            BTN_EDIT.Enabled = x;
            lstPlantas.Enabled = x;
         

        }

        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            EnableOrNotAllCommands(true);
        }
    }



}

