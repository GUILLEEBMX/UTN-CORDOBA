using API_Automotriz.Services;
using AutomotrizLibrary.Context;
using AutomotrizLibrary.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;

namespace API_Automotriz.Repository
{
    public class EmployRepository : IEmployServices
    {
        public EmployRepository()
        {
            Context.GetConnection();
        }

        public ActionResult<List<Employ>> GetAllEmployees()
        {

            var employList = Context.GetConnection().GetFromDataBase("CARGAR_EMPLEADOS");


            if (employList == null)
            {
                return new BadRequestObjectResult("HA OCURRIDO UN ERROR");
            }

            List<Employ> employees = new List<Employ>();

            foreach (DataRow rows in employList.Rows)
            {
                Employ employ = new Employ();
                employ.IdEmpleado = (int)rows[employList.Columns[0].ColumnName];
                employ.Nombre = rows[employList.Columns[6].ColumnName].ToString() ;
                employees.Add(employ);

            }

            return new OkObjectResult(employees);


        }
    }
}
