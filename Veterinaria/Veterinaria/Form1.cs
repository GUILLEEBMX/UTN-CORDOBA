using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    
    public partial class Form1 : Form
    {
        Context context = new Context(); // INSTANCIA CLASE DB
        DataTable table = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCBO(); // CARGAR COMBO NOMBRE DE SU METODO
            CargarLista(); // LLAMADA AL METODO CARGAR LISTA ();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       private void LoadCBO()
        {
            table = context.LeerBD("SELECT  * FROM ESPECIES");
            CBO_Especie.DataSource = table;
            CBO_Especie.ValueMember = "idEspecie";
            CBO_Especie.DisplayMember = "nombreEspecie";
        
            
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarLista()
        {
            //context es mi objeto de mi clase DB --
            //LeerBD = leerBD(); --USTEDES

            LST_Mascotas.Items.Clear(); //LIMPIAR ITEMS

            table = context.LeerBD("SELECT * FROM MASCOTAS");
           



            foreach (DataRow row in table.Rows)
            {
                Mascota pet = new Mascota();

                pet.Codigo = (int)row["codigo"]; //PARSEO DE OBJECT A
                pet.Especie = (int)row["especie"];//PARSEO DE OBJECT A
                pet.Nombre = (string)row["nombre"];//PARSEO DE OBJECT A
                pet.Sexo = (int)row["sexo"];//PARSEO DE OBJECT A
                pet.FechaNacimiento = (DateTime)row["fechaNacimiento"];//PARSEO DE OBJECT A
                LST_Mascotas.Items.Add(pet); //AÑADIENDO EL OBJETO  MASCOTAS A LA LISTA

            }



        }

        private void BTN_Record_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(TXT_Codigo.Text);

            for (int i = 0; i < context.PrimaryKeyValues().Length; i++)
            {
                if(codigo == context.PrimaryKeyValues()[i])
                {
                    if(MessageBox.Show("ESE CODIGO YA EXISTE EN NUESTRA BD ELIGE OTRO...") == DialogResult.OK)
                    {
                        TXT_Codigo.Clear();
                        return;
                        
                    }
                }

               


            }



            int sexo = 0;

            if (RDBT_Hembra.Checked)
            {
                sexo = 2;
            }

            if(RDBT_Macho.Checked)
            {
                sexo = 1;
            }
           


            Mascota pet = new Mascota();
            pet.Codigo = int.Parse(TXT_Codigo.Text);
            pet.Nombre = TXT_Name.Text; //.TEXT ES UN STRING
            pet.Especie = (int)CBO_Especie.SelectedValue; //SELECTED INDEX = ENTEROS--
            pet.Sexo = sexo;
            pet.FechaNacimiento = DatePicker.Value;

            string insertQuery = "INSERT INTO MASCOTAS VALUES(@codigo,@nombre,@especie,@sexo,@fechaNacimiento)";

            List<Parametro> param = new List<Parametro>();

            param.Add(new Parametro("@codigo", pet.Codigo));
            param.Add(new Parametro("@nombre", pet.Nombre));
            param.Add(new Parametro("@especie", pet.Especie));
            param.Add(new Parametro("@sexo", pet.Sexo));
            param.Add(new Parametro("@fechaNacimiento", pet.FechaNacimiento));


            int rowAffecteds = context.GrabarBD(insertQuery, param);

            if(rowAffecteds != 0)
            {
               if(MessageBox.Show ("SE INSERTO CORRECTAMENTE...") == DialogResult.OK)
                {
                    LST_Mascotas.Items.Clear();
                    CargarLista();
                }
               
            }



        }

        private void TXT_Codigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
