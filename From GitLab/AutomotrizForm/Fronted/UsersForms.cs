using API_Automotriz.Services;
using AutomotrizForm.Services;
using AutomotrizLibrary.Domain;
using AutomotrizLibrary.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AutomotrizForm.Fronted
{
    public partial class UsersForms : Form
    {
        private readonly IUserClientServices userServices;
        private readonly IValidatorServices validatorServices;
        public UsersForms(IUserClientServices userServices, IValidatorServices validatorServices)
        {
            InitializeComponent();
            this.userServices = userServices;
            this.validatorServices = validatorServices;
        }

       
        private async void AceptRegister_Click(object sender, EventArgs e)
        {
            if (validatorServices.ValidateNurlOrEmptyTextboxs(txtNombreRegisterUser, "NOMBRE"))
            {
                return;
            }
            if (validatorServices.ValidateNurlOrEmptyTextboxs(txtEmailRegisterUser, "EMAIL"))
            {
                return;
            }
            if (validatorServices.ValidateNurlOrEmptyTextboxs(txtPasswordRegisterUser, "PASSWORD"))
            {
                return;
            }
            await userServices.RegisterUsers(txtNombreRegisterUser, txtEmailRegisterUser, txtPasswordRegisterUser, dgvUsers);
        }

       

        private async void btnAceptRegisterAdmin_Click(object sender, EventArgs e)
        {


            if (validatorServices.ValidateNurlOrEmptyTextboxs(txtDeleteAdmin, "EMAIL"))
            {
                return;
            }
           

            await userServices.RegisterAdmin(txtEmailAdmin, dgvUsers);
        }

        private async void btnAceptDeleteAdmin_Click(object sender, EventArgs e)
        {
            if (validatorServices.ValidateNurlOrEmptyTextboxs(txtDeleteAdmin, "EMAIL"))
            {
                return;
            }


            if (validatorServices.ButtonDeleteClick(sender, e))
            {
                await userServices.DeleteAdmin(txtDeleteAdmin, dgvUsers);

            }
            
        }

        private async void btnAceptDeleteUser_Click(object sender, EventArgs e)
        {
            if (validatorServices.ValidateNurlOrEmptyTextboxs(txtEmailDeleteUser, "EMAIL"))
            {
                return;
            }

            if (validatorServices.ButtonDeleteClick(sender, e))
            {
                await userServices.DeleteUser(txtEmailDeleteUser, dgvUsers);
            }



        }

        private async void UsersForms_Load_1(object sender, EventArgs e)
        {
            await userServices.LoadAllUsers(dgvUsers);
            userServices.LoadCboAdminOrNot(cboEsAdminRegisterUser);
        }
    }

}



