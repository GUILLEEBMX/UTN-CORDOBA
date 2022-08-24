using Carpinteria.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpinteria.Services
{
    public interface IFormBudgetValidatorService
    {
        void ButtonAddClick(object sender, EventArgs e, ComboBox cboProducts, TextBox txtAmount, DataGridView detailsDgv);
        void ButtonCancelClick(object sender, EventArgs e,Application application);
        void ButtonAceptClick(object sender, EventArgs e, TextBox txtClient, DataGridView detailsDgv, TextBox txtDiscount);
        void SaveBudget(TextBox txtClient, TextBox txtDiscount);
        
    }
}
