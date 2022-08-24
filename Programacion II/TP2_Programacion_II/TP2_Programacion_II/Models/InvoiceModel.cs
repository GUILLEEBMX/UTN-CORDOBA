using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Programacion_II.Models
{
    public class InvoiceModel
    {
        public InvoiceModel()
        {
            DetailListInvoice = new List<DetailInvoice>();

        }

        public DateTime Date { get; set; }
        public int PaymentMethod { get; set; }
        public string Client { get; set; }
        public List<DetailInvoice> DetailListInvoice { get; }

        public void AddDetail(DetailInvoice detailInvoice)
        {
            if (detailInvoice != null)
            {
                DetailListInvoice.Add(detailInvoice);
            }
        }

        public void DeleteDetail(DetailInvoice detailInvoice)
        {
            if (detailInvoice != null)
            {
                DetailListInvoice.Remove(detailInvoice);
            }
        }


    }
}
