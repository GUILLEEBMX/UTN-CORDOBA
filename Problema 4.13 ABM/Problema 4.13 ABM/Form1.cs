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

namespace Problema_4._13_ABM
{
    public partial class Form1 : Form
    {
        private Persona [] people;
        static string connectionString = @"Data Source = .\SQLEXPRESS; Initial Catalog = PEOPLE; Integrated Security = True";
        SqlConnection context = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand();




        public Form1()
        {
            InitializeComponent();
            people = new Persona [52];
          
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Persona person = new Persona();




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            



        }

        private void TXT_APELLIDO_TextChanged(object sender, EventArgs e)
        {

         
           
        }

        private void TXTNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            FalseAllCommands();
            
            //LISTBOX
            lstDATOS.Focus();

            //COMBO BOX TIPO DOCUMENTOS
            cboTIPODOCUMENTO.Items.Add(1);
            cboTIPODOCUMENTO.Items.Add(2);
            cboTIPODOCUMENTO.Items.Add(3);

            //COMBO BOX TIPOS ESTADOS CIVILES
            cboESTADOCIVIL.Items.Add("SOLTERO");
            cboESTADOCIVIL.Items.Add("CASADO");
            cboESTADOCIVIL.Items.Add("VIUDO");
            cboESTADOCIVIL.Items.Add("SEPARADO");
            cboESTADOCIVIL.Items.Add("DIVORCIADO");

           

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            EmptyAllCommands();

            EnabledAllCommandsLoadDates();
           
            btnCANCEL.Enabled = true;
            btnRECORD.Enabled = true;
            btnEDIT.Enabled = false;
            btnDELETE.Enabled = true;
            TXTApellido.Focus();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void lblFallecido_Click(object sender, EventArgs e)
        {

        }

        private void rdnFEMENINO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboTIPODOCUMENTO_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void cboESTADOCIVIL_SelectedIndexChanged(object sender, EventArgs e)
        {


            

        }

        private void TXTApellido_KeyPress(object sender, KeyPressEventArgs e)
        {

            
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
         
            EnabledAllCommandsLoadDates();
            btnCANCEL.Enabled = true;
            btnRECORD.Enabled = true;
            btnNEW.Enabled = false;
            btnEDIT.Enabled = false;
            btnDELETE.Enabled = false;
            lstDATOS.Enabled = false;
            TXTApellido.Focus();


        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            var result =  MessageBox.Show("¿DESEA ELIMINAR REALMENTE ?","ABM", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < people.Length; i++)
                {
                    people[i] = null;
                    
                }
            }

            int index = lstDATOS.SelectedIndex;

            if (index != -1 )
            {
                lstDATOS.Items.RemoveAt(index);
            }


        }

        private void btnRECORD_Click(object sender, EventArgs e)
        {
            int rdbtn = 0;

            if (!rdnFEMENINO.Checked)
            {
                rdbtn = 1; 
            }

            int fallecido = 0;
            
            if (!ChecxBoxFallecido.Checked)
            {
                fallecido = 1;
            }

            InsertCleaner("ventas");

            cmd.ExecuteNonQuery();

            context.Close();

            //cmd.CommandText = "INSERT [dbo].[personas] ([apellido], [nombres], [tipo_documento], [documento], [estado_civil], [sexo], [fallecio]) VALUES('" +
            //        TXTApellido.Text + "','" + TXTNombres.Text + "'," +
            //        cboTIPODOCUMENTO.Text + "," +
            //        cboTIPODOCUMENTO.SelectedIndex + "," +
            //        cboESTADOCIVIL.SelectedIndex +
            //        "," +
            //        rdbtn + ",'" +
            //        fallecido + "')";

            //cmd.CommandText = "INSERT [dbo].[personas] ([apellido], [nombres], [tipo_documento], [documento], [estado_civil], [sexo], [fallecio])" +
            //    " VALUES('" + TXTApellido.Text + "','" + TXTNombres.Text + "'," +
            //       cboTIPODOCUMENTO.Text + "," +
            //       cboTIPODOCUMENTO.SelectedIndex + "," +
            //       cboESTADOCIVIL.SelectedIndex +
            //       "," +
            //       rdbtn + ",'" +
            //       fallecido + "')";

            //context.Open();

            //cmd.Connection = context;
            //cmd.ExecuteNonQuery();

            //context.Close();




            Persona person = new Persona();
            person.Apellido = TXTApellido.Text;
            person.Nombres = TXTNombres.Text;
            person.Documento = int.Parse(TXTDocumento.Text);
            person.TipoDNI = cboTIPODOCUMENTO.SelectedIndex;
            person.EstadoCivil = cboESTADOCIVIL.SelectedIndex;
            person.Sexo = rdbtn;
            person.Fallecido = fallecido;

           

            
            for (int i = 0; i < people.Length ; i++)
            {
                if (people[i] == null)
                {
                    people[i] = person;
                    lstDATOS.Items.Insert(i, person);
                    break;
                }

            }

            var results = MessageBox.Show("THE PERSON HAS RECORDED SUCCESSFULLY","ABM",MessageBoxButtons.OK);

            if (results == DialogResult.OK)
            {
                EmptyAllCommands();
            }



        }

      
        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            EmptyAllCommands();
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿DO YOU REALLY WANT CLOSE THE APP?", "EXIT", MessageBoxButtons.OK);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void ListboxDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPeople_Click(object sender, EventArgs e)
        {

        }

        private void EmptyAllCommands()
        {
            TXTApellido.Text = string.Empty;
            TXTNombres.Text = string.Empty;
            TXTDocumento.Text = string.Empty;
            cboESTADOCIVIL.Text = string.Empty;
            cboTIPODOCUMENTO.Text = string.Empty;
            rdnFEMENINO.Checked = false;
            rdnMASCULINO.Checked = false;
            ChecxBoxFallecido.Checked = false;
            lstDATOS.Text = string.Empty;
        }

        private void FalseAllCommands()
        {
            TXTApellido.Enabled = false;
            TXTNombres.Enabled = false;
            TXTDocumento.Enabled = false;

            //CBOs
            cboESTADOCIVIL.Enabled = false;
            cboTIPODOCUMENTO.Enabled = false;

            //RDNs
            rdnFEMENINO.Enabled = false;
            rdnMASCULINO.Enabled = false;

            ChecxBoxFallecido.Enabled = false;

            //BUTTONs 
            btnRECORD.Enabled = false;
            btnCANCEL.Enabled = false;
        }

        private void EnabledAllCommandsLoadDates()
        {
            TXTApellido.Enabled = true;
            TXTNombres.Enabled = true;
            TXTDocumento.Enabled = true;
            cboESTADOCIVIL.Enabled = true;
            cboTIPODOCUMENTO.Enabled = true;
            rdnFEMENINO.Enabled = true;
            rdnMASCULINO.Enabled = true;
            ChecxBoxFallecido.Enabled = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstDATOS.Items.Clear();

            context.Open(); //cnn

            cmd.CommandText = "SELECT * FROM PERSONAS";

            cmd.Connection = context;

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable ();

            table.Load(reader);

          
                for (int j = 0; j < table.Rows.Count ; j++)
                {
                    lstDATOS.Items.Insert(j, table.Rows[j].ItemArray[0] + " " + table.Rows[j].ItemArray[1]);
                }

            context.Close();

        }


        private string  InsertCleaner(string tableName)
        {
            int rdbt = 0;

            if (!rdnFEMENINO.Checked)
            {
                rdbt = 1;
            }

            int fallecido = 0;

            if (!ChecxBoxFallecido.Checked)
            {
                fallecido = 1;
            }

            cmd.CommandText = "SELECT * FROM " + tableName;

            context.Open();

            cmd.Connection = context;

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();

            table.Load(reader);


            string[] columNames = new string[table.Columns.Count];

            string _columNames = " ";



            for (int i = 0; i < table.Columns.Count; i++)
            {
                columNames[i] = table.Columns[i].ToString();

                _columNames +=columNames[i] + ",";

       
            }

            context.Close();

            
            var cortarComa =  _columNames.Length - 1;

           _columNames = _columNames.Substring(0,cortarComa);

            textBox1.Text = _columNames;


            //textBox1.Text = cmd.CommandText = "INSERT INTO " + tableName + "(" + _columNames + ")" +
            //     "VALUES" + "(" + "'" + TXTApellido.Text + "'" + "," + "'" + TXTNombres.Text + "'" + ","
            //      + 1 + "," + 45698745 + "," + 1 + "," + 2 + "," + 0 + ")";

            return  cmd.CommandText = "INSERT INTO " + tableName + "(" + _columNames + ")" +
            "VALUES" + "(" + "'" + TXTApellido.Text + "'" + "," + "'" + TXTNombres.Text + "'" + ","
             + 1 + "," + int.Parse(TXTDocumento.Text) + "," + 1 + "," + rdbt + "," + fallecido + ")";

            //context.Open();

            //cmd.ExecuteNonQuery();

            //context.Close();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InsertCleaner("personas");
        }

        private void CleanLst_Click(object sender, EventArgs e)
        {
            lstDATOS.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
