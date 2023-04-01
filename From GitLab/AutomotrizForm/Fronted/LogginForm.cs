using API_Automotriz.Services;
using AutomotrizForm.Fronted;
using AutomotrizForm.Services;
using AutomotrizLibrary.Domain;
using AutomotrizLibrary.DTOs;
using Newtonsoft.Json;
using System.Text;
using System.Windows.Forms;

namespace AutomotrizForm
{
    public partial class LogginForm : Form
    {

        private readonly IUserLoggiClient userLogginServices;
        private readonly IValidatorServices validatorServices;
        public LogginForm(IUserLoggiClient userLogginServices, IValidatorServices validatorServices)
        {
            InitializeComponent();
            this.userLogginServices = userLogginServices;
            txtUser.Text = "gbritos13@gmail.com";
            txtPassword.Text = "Rolling13.";
            this.validatorServices = validatorServices;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (validatorServices.ValidateNurlOrEmptyTextboxs(txtUser, "USUARIO"))
            {
                return;
            }

            if (validatorServices.ValidateNurlOrEmptyTextboxs(txtPassword, "PASSWORD"))
            {
                return;
            }

            await userLogginServices.UserLoggin(txtUser, txtPassword);
        }

        private void LogginForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (validatorServices.ButtonCancelClick(sender, e))
            {
                this.Close();
                this.Dispose();
            }
        }
    }
}