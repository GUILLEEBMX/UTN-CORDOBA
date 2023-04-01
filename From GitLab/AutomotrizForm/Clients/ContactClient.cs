using AutomotrizForm.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizForm.Clients
{
    public  class ContactClient : IContactServices
    {
        private readonly HttpClient request;
        public ContactClient(HttpClient request)
        {
            this.request = request;
        }


        public async Task EmailSender(TextBox txtemail, TextBox txtMessage)
        {
            string url = "https://apiautomotriz.herokuapp.com/api/email";
            var result = await request.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
            {
               content = await result.Content.ReadAsStringAsync();
               MessageBox.Show("EL EMAIL HA SIDO ENVIADO EXITOSAMENTE...");
               txtemail.Clear();
               txtMessage.Clear();
               
            }
            else
            {
                MessageBox.Show("EL EMAIL NO PUDO SER ENVIADO REINTENTAR...");
            }   

          
         

        }
    }
}
