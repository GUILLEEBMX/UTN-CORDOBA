using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form1()
        {
            InitializeComponent();
            people = new Persona [52];
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
            
            //LISTBOX
            lstDATOS.Focus();

            //COMBO BOX TIPO DOCUMENTOS
            cboTIPODOCUMENTO.Items.Add("DNI");
            cboTIPODOCUMENTO.Items.Add("CEDULA");
            cboTIPODOCUMENTO.Items.Add("LIBRETA");

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




            Persona person = new Persona();
            person.Apellido = TXTApellido.Text;
            person.Nombres = TXTNombres.Text;
            person.Documento = TXTDocumento.Text;
            person.TipoDNI = cboTIPODOCUMENTO.Text;
            person.EstadoCivil = cboESTADOCIVIL.Text;

            if (rdnFEMENINO.Checked == true)
            {
                person.Sexo = "F";
            }

            if (rdnMASCULINO.Checked == true)
            {
                person.Sexo = "M";
            }

            if (ChecxBoxFallecido.Checked == true)
            {
                person.Fallecido = "Fallecido";
            }

            
            for (int i = 0; i < people.Length ; i++)
            {
                if (people[i] == null)
                {
                    people[i] = person;
                    lstDATOS.Items.Insert(i, person.ToString());
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
    }
}
