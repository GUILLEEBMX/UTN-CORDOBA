using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_Programacion_II.Services
{
    public interface IFormInvoiceValidatorServices
    {
        void ButtonAddClick(object sender, EventArgs e, ComboBox cboProducts, TextBox txtAmount, DataGridView detailsDgv);
        void ButtonCancelClick(object sender, EventArgs e, Application application);
        void ButtonAceptClick(object sender, EventArgs e, TextBox txtClient, TextBox txtAmount, DataGridView detailsDgv, ComboBox cboArticles, ComboBox cboPaymentMethod);
        void SaveInvoice(TextBox txtClient, TextBox txtAmount, ComboBox cboPaymentMethod, ComboBox cboArticles);
        void ValidatorOnlyNumbers(object sender, KeyPressEventArgs e);
      


    }
}
