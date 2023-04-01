using AutomotrizLibrary.Context;
using AutomotrizLibrary.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;
using System;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
using API_Automotriz.Services;

namespace API_Automotriz.Repository
{
    public class ClientRepository:IClientServices 
    {
        public ClientRepository()
        {
            Context.GetConnection();
        }

        public ActionResult<List<Client>> GetAllClients()
        {
            try
            {
                var clientsList = Context.GetConnection().GetFromDataBase("GET_CLIENTS");


                if (clientsList == null)
                {
                    return new BadRequestObjectResult("HA OCURRIDO UN ERROR");
                }

                List<Client> clients = new List<Client>();

                foreach (DataRow rows in clientsList.Rows)
                {
                    Client client = new Client();
                    client.IdCliente = (int)rows[clientsList.Columns[0].ColumnName];
                    client.nombre = rows[clientsList.Columns[5].ColumnName].ToString();



                    clients.Add(client);

                }


                return clients;



            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult("HA OCURRIDO UN ERROR");

            }
        }
    }
}
