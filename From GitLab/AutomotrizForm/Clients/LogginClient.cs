using AutomotrizForm.Fronted;
using AutomotrizForm.Services;
using AutomotrizLibrary.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizForm.Clients
{
    public  class LogginClient : IUserLoggiClient
    {
        private readonly HttpClient request;
        private readonly PrincipalMenuForm principalMenu;
        private readonly UserLogginDTO userLoggin;
        public LogginClient(HttpClient request , UserLogginDTO userLoggin, PrincipalMenuForm principalMenu)
        {
            this.request = request;
            this.principalMenu = principalMenu;
            this.userLoggin = userLoggin;
                  
        }

        public async Task UserLoggin(TextBox txtUser, TextBox txtPassword)
        {

            userLoggin.Email = txtUser.Text;
            userLoggin.Contraseña = txtPassword.Text;


            string bodyContent = JsonConvert.SerializeObject(userLoggin);


            string url = "https://localhost:5001/users/loggin";

            var response = "";
            StringContent content = new StringContent(bodyContent, Encoding.UTF8, "application/json");
            var result = await request.PostAsync(url, content);


            if (result.IsSuccessStatusCode)
            {
                response = await result.Content.ReadAsStringAsync();
                if (MessageBox.Show(response) == DialogResult.OK)
                {
                    principalMenu.ShowDialog();

                }


            }
            else
            {
                response = await result.Content.ReadAsStringAsync();
                MessageBox.Show(response);

            }


        }
    }
}
