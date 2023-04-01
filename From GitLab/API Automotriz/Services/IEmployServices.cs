using AutomotrizLibrary.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API_Automotriz.Services
{
    public interface IEmployServices
    {
        public ActionResult<List<Employ>> GetAllEmployees();
    }
}
