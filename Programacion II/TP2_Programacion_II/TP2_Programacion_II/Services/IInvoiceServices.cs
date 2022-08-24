using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2_Programacion_II.Models;

namespace TP2_Programacion_II.Services
{
    interface IInvoiceServices
    {
        void AddDetail(DetailInvoice detailInvoice);
        void DeleteDetail(DetailInvoice detailInvoice);
    }
}
