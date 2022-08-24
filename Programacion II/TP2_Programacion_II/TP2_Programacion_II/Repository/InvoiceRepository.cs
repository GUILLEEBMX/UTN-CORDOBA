using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2_Programacion_II.Models;
using TP2_Programacion_II.Services;

namespace TP2_Programacion_II.Repository
{
    class InvoiceRepository : IInvoiceServices
    {
        private readonly InvoiceModel invoice;
        public InvoiceRepository(InvoiceModel _invoice)
        {
            invoice = _invoice;
        }
        public void AddDetail(DetailInvoice detailInvoice)
        {
            if (detailInvoice != null)
            {
                invoice.DetailListInvoice.Add(detailInvoice);
            }
        }

        public void DeleteDetail(DetailInvoice detailInvoice)
        {
            if (detailInvoice != null)
            {
                invoice.DetailListInvoice.Remove(detailInvoice);
            }
        }
    }
}
