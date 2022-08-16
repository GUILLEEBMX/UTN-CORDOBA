using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Programacion_II
{
    public partial class Form1 : Form
    {
        Context context = new Context();
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            LoadCBOCarriers();
          
            txtTituloCarrera.Text = "ABOGADO";
            txtCuatrimestre.Text = "PRIMERO";
            txtMateria.Text = "Test";
           

        }

        private void cbocarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void LoadCBOAsignaturas()
        {
  
            DataTable table = new DataTable() ;
            table = context.GetFromDataBase("SELECT * FROM ASIGNATURAS");
            cboAsignaturas.DataSource = table;
            cboAsignaturas.ValueMember = "id_asignatura";
            cboAsignaturas.DisplayMember  = "nombre";

            

        }

        private void LoadCBOCarriers()
        {

            DataTable table = new DataTable();
            table = context.GetFromDataBase("SELECT * FROM CARRERAS");
            cboCarreras.DataSource = table;
            cboCarreras.ValueMember = "id_carrera";
            cboCarreras.DisplayMember = "nombre";


        }

        private void cboAsignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRecord_Click(object sender, EventArgs e)
        {

            //Carrera carrier = new Carrera();
            DetalleCarrera carrierDetails = new DetalleCarrera();
            //carrier.Nombre = txtNombreCarrera.Text;
            //carrier.Titulo = lblTituloCarrera.Text;
            carrierDetails.Carrera = 1;
            carrierDetails.AnioCursado = (DateTime)datePicker.Value;
            carrierDetails.Cuatrimestre = txtCuatrimestre.Text;
            carrierDetails.Materia = txtMateria.Text;
            carrierDetails.Asignatura = cboCarreras.SelectedIndex;


            string query = "INSERT INTO DETALLES_CARRERAS VALUES (@carrera,@anio_cursado,@cuatrimestre,@materia)";

            List<Parameter> valuesToInsert = new List<Parameter>();


            valuesToInsert.Add(new Parameter("@carrera", carrierDetails.Carrera));

            valuesToInsert.Add(new Parameter("@anio_cursado", carrierDetails.AnioCursado));

            valuesToInsert.Add(new Parameter("@cuatrimestre", carrierDetails.Cuatrimestre));

            valuesToInsert.Add(new Parameter("@materia", carrierDetails.Materia));

            int rowAffecteds = context.PostToDatabase(query, valuesToInsert);

            if (rowAffecteds != 0)
            {
                if (MessageBox.Show("The insertion into database has successfully...") == DialogResult.OK)
                {

                    //EnableOrNotAllCommands(false);
                    //lstPlantas.Items.Clear();
                    //LoadList();
                }

            }

        }

        private void cboCarreras_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboCarreras.SelectedIndex == 5)
            {
                LoadCBOAsignaturas();

            }
            else
            {
                cboAsignaturas.Items.Add("NOT FOUND");
            }

        }
    }
}

