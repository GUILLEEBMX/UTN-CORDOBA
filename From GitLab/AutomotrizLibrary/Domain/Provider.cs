using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizLibrary.Domain
{
    public class Provider
    {
        public int Id { get; set; }

        public int IdBarrio { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }
    }
}
