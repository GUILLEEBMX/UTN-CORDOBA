using  RecetasSLN.Context;
using RecetasSLN.dominio;
using RecetasSLN.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.Implementacion
{
    public class PrescriptionRepository : IPrescriptionService
    {
        public DataTable GetFromDataBaseIngredients()
        {
            return Context.Context.GetInstance().GetFromDataBase("SP_CONSULTAR_INGREDIENTES");
        }

        public DataTable GetFromDataBasePrescriptionTypes()
        {
            return Context.Context.GetInstance().GetFromDataBase("SP_CONSULTAR_TIPOS_RECETAS");
        }

        public int PostToDataBase(Prescription prescription)
        {
            return Context.Context.GetInstance().PostToDataBase("SP_INSERTAR_RECETA", prescription);

        }

        public DataTable GetFromDataBasePrescriptions()
        {
            return Context.Context.GetInstance().GetFromDataBase("SP_CONSULTAR_RECETAS");
        }







    }
}
