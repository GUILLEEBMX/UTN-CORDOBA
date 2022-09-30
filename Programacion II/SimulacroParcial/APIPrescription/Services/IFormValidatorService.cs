using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIPrescription.Services
{
    public interface IFormValidatorService
    {
        bool ValidateIngredients(DataGridView dgvPrescription, ComboBox cboIngredients);
        bool ValidateAmountIngredients(DataGridView dgvPrescription);
        void ValidatorOnlyNumbers(object sender, KeyPressEventArgs e);

        bool ValidateFields(TextBox textboxt);

    }
}
