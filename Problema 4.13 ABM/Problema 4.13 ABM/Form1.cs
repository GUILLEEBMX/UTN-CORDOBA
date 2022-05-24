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

        static string connectionString = @"Data Source = .\SQLEXPRESS; Initial Catalog = PEOPLE; Integrated Security = True";
        SqlConnection context = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand();


        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
      
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
            lstDATOS.Focus();
            LoadCombos("tipo_documento");
            LoadCombos("estado_civil");
           
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
            if (lstDATOS.SelectedIndex == -1)
            {
                MessageBox.Show("DEBE SELECCIONAR UNA PERSONA");
            }

            else
            {

            var result =  MessageBox.Show("¿DESEA ELIMINAR REALMENTE ?","ABM", MessageBoxButtons.YesNo);
     
            if (result == DialogResult.Yes)
            {
                
                var DNI = lstDATOS.SelectedItem.ToString();
                int index = lstDATOS.SelectedIndex;
                
                for (int i = 0; i < PrimaryKeyValues().Length; i++)
                {
                   if(DNI.Contains(PrimaryKeyValues()[i].ToString()))
                    {
                        cmd.CommandText = "DELETE FROM PERSONAS WHERE DOCUMENTO = " + PrimaryKeyValues()[i];
                        context.Open();
                        cmd.ExecuteNonQuery();
                        context.Close();

                    }

                }

                if (index != -1)
                {
                    lstDATOS.Items.RemoveAt(index);
                    
                }

            }

            

            }

            
        }

        private void btnRECORD_Click(object sender, EventArgs e)
        {
            cmd.Connection = context;

            cmd.CommandText = InsertCleaner("personas");

            context.Open();

            cmd.ExecuteNonQuery();

            context.Close();

            var results = MessageBox.Show("THE PERSON HAS RECORDED SUCCESSFULLY", "ABM", MessageBoxButtons.OK);

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

            context.Open(); 

            cmd.CommandText = "SELECT * FROM PERSONAS";

            cmd.Connection = context;

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable ();

            table.Load(reader);

          
                for (int j = 0; j < table.Rows.Count ; j++)
                {
                    lstDATOS.Items.Insert(j, table.Rows[j].ItemArray[0] + " " + table.Rows[j].ItemArray[1]
                                                + " "  + "DNI: "+ table.Rows[j].ItemArray[3]);
                }

            context.Close();

        }


        private string InsertCleaner(string tableName)
        {
            int rdbt = 0;

            if (!rdnFEMENINO.Checked)
            {
                rdbt = 0;
            }

            int fallecido = 0;

            if (!ChecxBoxFallecido.Checked)
            {
                fallecido = 0;
            }

            int tipoDocumento = 0;

            if(cboTIPODOCUMENTO.Text == "DNI")
            {
                tipoDocumento = 1;

            }

            int estadoCivil = 0;

            if(cboESTADOCIVIL.Text == "Soltero")
            {
                estadoCivil = 1;
            }
           
       

            int documento = int.Parse(TXTDocumento.Text);

      
            TXTApellido.Text = TXTApellido.Text.Insert(0, "(").Insert(1, "'").Insert(TXTApellido.Text.Length + 2, "'")
                               .Insert(TXTApellido.Text.Length + 3, ",");

          
            TXTNombres.Text = TXTNombres.Text.Insert(0, "'")
                                .Insert(TXTNombres.Text.Length + 1, "'").Insert(TXTNombres.Text.Length + 2, ",");
                              

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

           _columNames = _columNames.Insert(0, "(").Insert(_columNames.Length+1, ")");

            string finalQueryInsert = "INSERT INTO " + tableName + _columNames +
                                      "VALUES" + TXTApellido.Text + TXTNombres.Text
                                      + tipoDocumento + "," + documento + "," + estadoCivil + "," + rdbt + "," + fallecido + ")";

            return finalQueryInsert;

        }

        private void CleanLst_Click(object sender, EventArgs e)
        {
            lstDATOS.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTDocumento_TextChanged(object sender, EventArgs e)
        {
            var response = 0;
            for (int i = 0; i < PrimaryKeyValues().Length; i++)
            {
                if (TXTDocumento.Text.Contains(PrimaryKeyValues()[i].ToString()))
                {
                    response = 1;                     
                }
            }

            if (response == 1)
            {
                MessageBox.Show("ESTE DNI YA EXISTE EN NUESTRA DB ELIGE OTRO...");
                TXTDocumento.Clear();
            }


        }

        private void LoadCombos(string tableName)
        {
            cmd.CommandText = "SELECT * FROM " + tableName;

            context.Open();

            cmd.Connection = context;

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();

            table.Load(reader);

            if (tableName != "estado_civil")
            {
                cboTIPODOCUMENTO.Items.Add(table.Rows[0].ItemArray[1].ToString());
            }

          
            if (tableName != "tipo_documento")
            {
                cboESTADOCIVIL.Items.Add(table.Rows[0].ItemArray[1].ToString());
            }
           

            context.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private int [] PrimaryKeyValues()
        {
            
            context.Open();

            cmd.CommandText = "SELECT * FROM PERSONAS";
            
            cmd.Connection = context;

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();

            table.Load(reader);

            context.Close();

            int[] documentos = new int[table.Rows.Count];

            for (int i = 0; i < table.Rows.Count; i++)
            {
               documentos[i] = (int)table.Rows[i].ItemArray[3];
            }

            return documentos;

        }

        private void UpdatePerson(string tableName,string columName)
        {
            
            cmd.CommandText = "UPDATE" + tableName + "SET" + columName + "WHERE DOCUMENTO = " +  5;
            cmd.Connection = context;
            context.Open();
            
        }

        
        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void TXTDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                if (MessageBox.Show("SOLO SE PERMITEN NUMEROS") == DialogResult.Yes)
                {
                    TXTDocumento.Clear();
                }
            }
        }
    }
}
