using Carpinteria.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpinteria.Services
{
    public interface IContextService
    {
        DataTable ExecProcedureFromDatabase(string nameProcedure);

        string NextBudget(Label lblnumberBudget);

        void CalculateTotal(TextBox txtTotal, TextBox txtDiscount, TextBox txtFinal);

        bool PostToDatabase(Budget budget);

        void LoaderCbo(ComboBox cboProducts);


    }
}
