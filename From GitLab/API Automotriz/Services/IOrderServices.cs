using AutomotrizLibrary;
using AutomotrizLibrary.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API_Automotriz.Services
{
    public interface IOrderServices
    {
        public ActionResult<List<Order>> GetAllOrders();

        public ActionResult<Order> GetID(int id);

        public ActionResult PostOrder(OrderPostDTO order);

    }
}
