using AutomotrizForm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizForm.Validators
{
    public  class ValidatorForm : IValidatorServices
    {
        public bool ButtonCancelClick(object sender, EventArgs e)
        {


            if (MessageBox.Show("¿REALMENTE QUIERES CANCELAR?") == DialogResult.OK)
            {
                return true;
            }

            return false;
        }

        public void ValidatorOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("SOLO SE PERMITEN NUMEROS");
                e.Handled = true;
            }

        }

        public bool ButtonDeleteClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ESTA SEGURO QUE DESEA BORRAR?") == DialogResult.OK)
            {
                return true;

            }

            return false;
        }

        public void ButtonCloseClick(object sender, EventArgs e, Application application)
        {
            if (MessageBox.Show("¿REALMENTE QUIERES CERRAR?") == DialogResult.OK)
            {

            }
        }
        
        public bool ValidateNurlOrEmptyTextboxs(TextBox textBox,string txtName)
        {

            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("EL CAMPO " + txtName + " NO PUEDE ESTAR VACIO....");
                return true;
            }

            return false;
        }


    }
}
