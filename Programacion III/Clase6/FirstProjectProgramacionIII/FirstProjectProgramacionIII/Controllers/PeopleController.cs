using FirstProjectProgramacionIII.Data;
using FirstProjectProgramacionIII.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace FirstProjectProgramacionIII.Controllers
{
    public class PeopleController : ControllerBase
    {

        //private readonly IPeople


        private readonly Context context; 

        public PeopleController(Context _context)
        {
            context = _context;

        }



        //[HttpGet]
        //[Route("api/people/getpeople")]
        //public async Task<ActionResult<List<Person>>> GetPeople()
        //{

        //    var people = await context.personas.toListAsync();


        //    return Ok(people);

        //}

        //[HttpGet]
        //[Route("api/people/getOnePeople/{id}")]
        //public async Task<ActionResult<People>> GetPeople(int id)
        //{

        //    //var people = await context.People.FirstOrDefaultAsync(x => x.Id == id)

        //    var people = await context.People.Where(x => x.Id == id).FirstOrDefaultAsync();

        //    return Ok(people);

        //}





    }
}
