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
    public class RequestTypeRepository : IRequestTypeServices
    {
        public RequestTypeRepository()
        {
            Context.GetConnection();
        }

        public ActionResult<List<RequestType>> GetAllRequestTypes()
        {


            var requestList = Context.GetConnection().GetFromDataBase("CARGAR_TIPOS_SOLICTIDES");


            if (requestList == null)
            {
                return new BadRequestObjectResult("HA OCURRIDO UN ERROR");
            }

            List<RequestType> requestTypes = new List<RequestType>();

            foreach (DataRow rows in requestList.Rows)
            {
                RequestType requestType = new RequestType();
                requestType.IdSolicitud = (int)rows[requestList.Columns[0].ColumnName];
                requestType.ViaSolicitud = rows[requestList.Columns[1].ColumnName].ToString();



                requestTypes.Add(requestType);

            }


            return new OkObjectResult(requestTypes);


        }

    }
}
