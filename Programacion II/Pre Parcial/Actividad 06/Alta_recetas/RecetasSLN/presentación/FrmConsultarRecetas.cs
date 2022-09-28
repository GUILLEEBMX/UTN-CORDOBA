using RecetasSLN.dominio;
using RecetasSLN.Implementacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetasSLN.presentación
{
    public partial class FrmConsultarRecetas : Form
    {
        private RecetaDao recetaDao;
        public FrmConsultarRecetas()
        {
            InitializeComponent();

            recetaDao = new RecetaDao();
        }

        private void cboTipoReceta_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void FrmConsultarRecetas_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarIngredientes();
        }

        private void CargarCombos()
        {
            cboTipoReceta.DataSource = recetaDao.ConsultarSQL("SP_CONSULTAR_TIPOS_RECETAS");
            cboTipoReceta.DisplayMember = "TIPO";
            cboTipoReceta.ValueMember = "ID_TIPO";


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            int bandera = 0;

            int bandera2 = 0;

            Receta receta = new Receta();
            DetalleReceta detalle = new DetalleReceta();



            receta.Nombre = txtNombre.Text;
            receta.Cheff = txtCheff.Text;
            receta.TipoReceta = (int)cboTipoReceta.SelectedValue;
            detalle.Ingrediente.IngredienteId = cboIngredientes.SelectedIndex;
            detalle.Cantidad = 10;
            //object
            //receta.TipoReceta = int.Parse(cboTipoReceta.SelectedValue.ToString());
            //tratamelo como un entero


            bandera = recetaDao.EjecutarSQL("SP_INSERTAR_RECETA",receta);


            receta.AgregarDetalle(detalle);

            bandera2 = recetaDao.InsertarDetalle("SP_INSERTAR_DETALLES",receta.DetalleReceta);


            if(bandera > 0)
            {
                MessageBox.Show("SE INSERTO CORRECTAMENTE");
            }




        }

        private void cboIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarIngredientes()
        {

            cboIngredientes.DataSource = recetaDao.ConsultarSQL("SP_CONSULTAR_INGREDIENTES");
            cboIngredientes.DisplayMember = "n_ingrediente";
            cboIngredientes.ValueMember = "id_ingrediente";
            
        }
    }
}
