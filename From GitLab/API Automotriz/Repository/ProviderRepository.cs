using API_Automotriz.Services;
using AutomotrizLibrary;
using AutomotrizLibrary.Context;
using AutomotrizLibrary.Domain;
using AutomotrizLibrary.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;

namespace API_Automotriz.Repository
{
    public class ProviderRepository : IProviderServices
    {
        public ProviderRepository()
        {
            Context.GetConnection();

        }

        public ActionResult<List<Provider>> GetAllProviders()
        {

            var providersList = Context.GetConnection().GetFromDataBase("CARGAR_PROVEEDORES");


            if (providersList == null)
            {
                return new BadRequestObjectResult("HA OCURRIDO UN ERROR");
            }

            List<Provider> providers = new List<Provider>();

            foreach (DataRow rows in providersList.Rows)
            {
                Provider provider = new Provider();
                provider.Id = (int)rows[providersList.Columns[0].ColumnName];
                provider.IdBarrio = (int)rows[providersList.Columns[1].ColumnName];
                provider.Nombre = rows[providersList.Columns[2].ColumnName].ToString();
                provider.Direccion = rows[providersList.Columns[3].ColumnName].ToString();
                providers.Add(provider);

            }

            return new OkObjectResult(providers);


        }


    }
}
