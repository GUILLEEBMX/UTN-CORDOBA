using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizForm.Services
{
    public interface IValidatorServices 
    {
        public bool ButtonCancelClick(object sender, EventArgs e);

        public void ValidatorOnlyNumbers(object sender, KeyPressEventArgs e);

        public bool ButtonDeleteClick(object sender, EventArgs e);

        public void ButtonCloseClick(object sender, EventArgs e, Application application);

        public bool ValidateNurlOrEmptyTextboxs(TextBox textBox, string txtName);
    }
}
