using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetasSLN.Interfaces
{
    public interface IPrescriptionService
    {

        DataTable GetFromDataBaseIngredients();

        DataTable GetFromDataBasePrescriptionTypes();

        int PostToDataBase(Prescription prescription);

        DataTable GetFromDataBasePrescriptions();

        String NextPrescription(Label lblNextPrescription);

        void LoadDataGridView(DataGridView dgvPrescription);

        void LoadCBOPrescriptionTypes(ComboBox cboPrescriptionTypes);

        void LoadCBOIngredients(ComboBox cboIngredients);


    }
}
