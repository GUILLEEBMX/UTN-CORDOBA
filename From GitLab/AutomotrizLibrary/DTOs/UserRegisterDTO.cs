using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizLibrary.DTOs
{
    public class UserRegisterDTO
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }

        public bool EsAdmin { get; set; }
    }
}
