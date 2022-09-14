using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Programacion_II.Models
{
    public class DetailInvoice
    {
        public int InvoiceId { get; set; }

        public int Amount { get; set; }

        public Article Article { get; set; }


    }
}
