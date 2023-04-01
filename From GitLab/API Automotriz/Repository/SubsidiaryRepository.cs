using API_Automotriz.Services;
using AutomotrizLibrary.Context;
using AutomotrizLibrary.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;

namespace API_Automotriz.Repository
{
    public class SubsidiaryRepository : ISubsidiaryServices
    {
        public SubsidiaryRepository()
        {
            Context.GetConnection();
        }

       
        public ActionResult<List<Subsidiary>> GetAllSubsidiaries()
        {

            var subsidiaryList = Context.GetConnection().GetFromDataBase("CARGAR_SUCURSALES");


            if (subsidiaryList == null)
            {
                return new BadRequestObjectResult("HA OCURRIDO UN ERROR");
            }

            List<Subsidiary> subsidiaries = new List<Subsidiary>();

            foreach (DataRow rows in subsidiaryList.Rows)
            {
                Subsidiary subsidiary = new Subsidiary();
                subsidiary.IdSucursal = (int)rows[subsidiaryList.Columns[0].ColumnName];
                subsidiary.IdBarrio = (int)rows[subsidiaryList.Columns[1].ColumnName];
                subsidiary.DireccionSucursal = rows[subsidiaryList.Columns[2].ColumnName].ToString();
                subsidiaries.Add(subsidiary);

            }

            return new OkObjectResult(subsidiaries);


        }

    }
}
