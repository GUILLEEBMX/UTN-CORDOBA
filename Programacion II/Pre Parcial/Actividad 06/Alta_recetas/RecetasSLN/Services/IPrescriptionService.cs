using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.Interfaces
{
    public interface IPrescriptionService
    {

        DataTable GetFromDataBaseIngredients();

        DataTable GetFromDataBasePrescriptionTypes();

        int PostToDataBase(Prescription prescription);

        DataTable GetFromDataBasePrescriptions();



    }
}
