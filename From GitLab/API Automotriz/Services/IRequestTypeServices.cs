using AutomotrizLibrary.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API_Automotriz.Services
{
    public interface IRequestTypeServices
    {
        public ActionResult<List<RequestType>> GetAllRequestTypes();
    }
}
