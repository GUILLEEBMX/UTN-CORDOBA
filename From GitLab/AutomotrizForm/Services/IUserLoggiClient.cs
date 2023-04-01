using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizForm.Services
{
    public interface IUserLoggiClient
    {
        public Task UserLoggin(TextBox txtPassword, TextBox txtUser);
    }
}
