using AutomotrizForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizForm.Fronted
{
    public partial class ContactForm : Form
    {
        private readonly IContactServices contactServices;
        private readonly IValidatorServices validatorServices;
        public ContactForm(IContactServices contactServices, IValidatorServices validatorServices)
        {
            InitializeComponent();
            this.contactServices = contactServices;
            this.validatorServices = validatorServices;
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if(validatorServices.ValidateNurlOrEmptyTextboxs(txtEmail, "EMAIL"))
            {
                return;
            }


            if (validatorServices.ValidateNurlOrEmptyTextboxs(txtMensaje, "MENSAJE"))
            {
                return;
            }

            await contactServices.EmailSender(txtEmail,txtMensaje);

        }

        private void ContactForm_Load(object sender, EventArgs e)
        {

        }
    }
}
