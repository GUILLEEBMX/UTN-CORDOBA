using API_Automotriz.Services;
using AutomotrizLibrary.Context;
using AutomotrizLibrary.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;

namespace API_Automotriz.Repository
{
    public class DeliveryRepository : IDeliverieServices
    {
        public DeliveryRepository()
        {
            Context.GetConnection();
        }

        public ActionResult<List<Delivery>> GetAllDeliveries()
        {

            var deliveriesList = Context.GetConnection().GetFromDataBase("CARGAR_ENTREGAS");


            if (deliveriesList == null)
            {
                return new BadRequestObjectResult("HA OCURRIDO UN ERROR");
            }

            List<Delivery> subsidiaries = new List<Delivery>();

            foreach (DataRow rows in deliveriesList.Rows)
            {
                Delivery delivery = new Delivery();
                delivery.IdEntrega = (int)rows[deliveriesList.Columns[0].ColumnName];
                delivery.Descripcion = rows[deliveriesList.Columns[1].ColumnName].ToString();
                subsidiaries.Add(delivery);

            }

            return new OkObjectResult(deliveriesList);


        }
    }
}
