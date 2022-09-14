using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2_Programacion_II.Models;

namespace TP2_Programacion_II.Services
{
    public interface IBudgetRepositoryServices
    {
        DataTable ExecProcedureFromDatabase(string nameProcedure);

        string NextInvoice(System.Windows.Forms.Label lblnumberBudget);

        bool PostToDatabase(InvoiceModel invoice);

        void LoaderArticles(ComboBox cboProducts);

        void LoaderPaymentMethods(ComboBox cboProducts);

        void DeleteFromDataBase(TextBox txtDelete);
    }
}
