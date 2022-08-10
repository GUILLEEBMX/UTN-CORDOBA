using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASSWORD
{
    public partial class Form1 : Form
    {
        private PASSWORD contraseña;
        public Form1()
        {

            contraseña = new PASSWORD();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_1.Text = $"{"EL PASSWORD DEBE CONTENER COMO MINIMO:"}\r\n{"5 NUMEROS"}\r\n{"2 MAYÚSCULAS"}\r\n{"1 MINÚSCULA"}\r\n{"MAXIMO 8 CARACTERES"}\r\n{"NO SE PERMITEN CARACTERES ESPECIALES"}";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
            if (txt_2.TextLength >= 8)

            {
                MessageBox.Show("SOLO SE PERMITE HASTA 8 CARACTERES ");


            }


   








    }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)

        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))

            {
                MessageBox.Show("SOLO NUMEROS Y LETRAS ");
                e.Handled = true;
                return;
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                contraseña.Pcontnumeros = contraseña.Pcontnumeros + 1;
            else if (e.KeyChar >= 65 && e.KeyChar <= 90)
                contraseña.Pcontmayusculas = contraseña.Pcontmayusculas + 1;
            else if (e.KeyChar >= 97 && e.KeyChar <= 122)
                contraseña.Pcontminusculas = contraseña.Pcontminusculas + 1;


    }

        private void button1_Click(object sender, EventArgs e)
        {

            if (contraseña.EsFuerte() == true)
                checkBox1.Checked = true;
            else checkBox1.Checked = false;

            contraseña.Pcontnumeros = 0;
            contraseña.Pcontmayusculas = 0;
            contraseña.Pcontminusculas = 0;



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {




        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            contraseña.Pcontnumeros = 0;
            contraseña.Pcontmayusculas = 0;
            contraseña.Pcontminusculas = 0;



            txt_1.Text = "EL PASSWORD GENERADO DE MANERA ALEATORIA ES:  " + contraseña.GenerarPassword();

            string aux;

            aux = txt_1.Text.Substring(46);

            char[] X;

            X = aux.ToCharArray();

            {

                for (int i = 0; i < X.Length; i++)
                {
                    if (X[i] >= 48 && X[i] <= 57)
                    {
                        contraseña.Pcontnumeros = contraseña.Pcontnumeros + 1;
                    }



                    else if (X[i] >= 65 && X[i] <= 90)
                        contraseña.Pcontmayusculas = contraseña.Pcontmayusculas + 1;


                    else if (X[i] >= 97 && X[i] <= 122)
                        contraseña.Pcontminusculas = contraseña.Pcontminusculas + 1;
                    
                }
            }



            if (contraseña.EsFuerte() == true)
                checkBox1.Checked = true;
            else checkBox1.Checked = false;

           

            
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}


