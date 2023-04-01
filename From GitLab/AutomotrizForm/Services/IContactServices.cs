using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizForm.Services
{
    public  interface IContactServices
    {
        public  Task EmailSender(TextBox txtemail, TextBox txtMessage);
    }
}
