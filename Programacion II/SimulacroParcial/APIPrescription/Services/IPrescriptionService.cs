using APIPrescription.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIPrescription.Services
{
    public interface IPrescriptionService
    {
        DataTable GetFromDataBase();

        int PostToDataBase(Prescription prescription);
        void LoadCBOPrescriptionTypes(ComboBox comboBox);
        void LoadCBOIngredients(ComboBox comboBox);

        string NextPrescription();







    }
}
