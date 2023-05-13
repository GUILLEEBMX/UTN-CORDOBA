using FirstProjectProgramacionIII.Data;
using FirstProjectProgramacionIII.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace FirstProjectProgramacionIII.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {

        private readonly Context context; 

        public PeopleController(Context _context)
        {
            context = _context;

        }



        [HttpGet]
        [Route("api/people/GetPeople")]

        public async Task<ActionResult<List<Person>>> GetPeople()
        {

            var people = await context.People.ToListAsync();


            return Ok(people);

        }

    
        [HttpGet]
        [Route("api/personas/GetPersonById/{id}")]
        public async Task<ActionResult<Person>> GetPeople(int id)
        {

            //var people = await context.People.FirstOrDefaultAsync(x => x.Id == id)

            var people = await context.People.Where(x => x.Id == id).FirstOrDefaultAsync();

            return Ok(people);

        }





    }
}
