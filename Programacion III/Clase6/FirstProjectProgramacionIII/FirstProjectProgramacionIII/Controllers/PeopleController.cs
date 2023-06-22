using FirstProjectProgramacionIII.CMD;
using FirstProjectProgramacionIII.Data;
using Microsoft.AspNetCore.Mvc;
using FirstProjectProgramacionIII.ResultModel;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using FirstProjectProgramacionIII.DTO;
using FirstProjectProgramacionIII.ResultModel.PersonResult;
using Microsoft.EntityFrameworkCore;
using FirstProjectProgramacionIII.Business.Personas;

namespace FirstProjectProgramacionIII.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {

        private readonly Context context;
        private readonly PeopleDTO people;

        //private readlonñu Imediator _mediator;


        public PeopleController(Context _context,PeopleDTO _people/*Imediator mediator*/)
        {
            context = _context;
            people = _people;
            //mediator = _mediator;
            

        }

        [HttpGet]
        [Route("api/people/GetPeople")]
        public async Task<Result<List<PeopleDTO>>> GetPeople()
        {

            //var peopleContext = await context.Users.ToListAsync();

            //PeopleDTO persona = new PeopleDTO();


            //  List<PeopleDTO> people = new List<PeopleDTO>();

            //people.Add(peopleContext.ForEach(x => new PeopleDTO(x.UserName, x.Password)));


            //return Result<people>;

            //Result<List<PeopleDTO>> result = new Result<List<PeopleDTO>>();

            //foreach (var person in peopleContext)
            //{
            //    person.UserName = peopleContext.
            //}

            //result.Values.Add(peopleContext);


            //var resultado = await _mediadtor.Send(new GetByIdBusiness.GetPersonaByIdComando {IdPersona = id });;
            

            //return resultado;

        }

        //MediatR.Extensions.Microsoft.DependencyInjection
        //FluentValidation.ASP NET CORE


    }


}







//[HttpGet]
//[Route("api/people/GetPeople")]

//public async Task<ActionResult<List<Person>>> GetPeople()
//{

//    var people = await context.People.ToListAsync();


//    return Ok(people);

//}


//[HttpGet]
//[Route("api/personas/GetPersonById/{id}")]
//public async Task<ActionResult<Person>> GetPeople(int id)
//{

//    //var people = await context.People.FirstOrDefaultAsync(x => x.Id == id)

//    var people = await context.People.Where(x => x.Id == id).FirstOrDefaultAsync();

//    return Ok(people);

//}

//[HttpGet]
//[Route("api/personas/GetPersonById/{id}")]
//public async Task<PersonResults> GetPeople()
//{

//    //var people = await context.People.FirstOrDefaultAsync(x => x.Id == id)

//    var result = new PersonResults();

//    var people = await context.People.ToListAsync();


//    if (people != null)
//    {
//        foreach (var person in people)
//        {
//            var person_ = new ItemPerson();
//            person_.Name = "GUILLERMO";
//            person_.Email = "gbritos13@gmail.com";

//        }

//        result.Error = "Null";
//        result.Success = true;
//        result.StatusCode = System.Net.HttpStatusCode.OK;
//    }


//    //var people = await context.SaveChangesAsync(person);

//    result.Error = "ERROR";
//    result.StatusCode = System.Net.HttpStatusCode.NotFound;

//    return result;

//}




//[HttpPost]
//[Route("api/personas/GetPersonById/{id}")]
//public async Task<ActionResult<Person>> CreatePeople(Person person)
//{

//    //var people = await context.People.FirstOrDefaultAsync(x => x.Id == id)

//    var people = await context.SaveChangesAsync(person);

//    return Ok(people);

//}


//[HttpGet]
//[Route("api/people/GetPeople")]

//public async Task<PersonResults> GetPeople()
//{

//    var result = new PersonResults();

//    var people  = await context.People.FirstOrDefaultAsync();

//    if(people != null)
//    {
//        //var itemPeople = new ItemPerson
//        //{
//        //    Email = people.Email,
//        //    Name = itemPeople.Name


//        //}

//.Include(detallesDB => detallesDB.DetallesVenta) // TO INCLUDE CATEGORIE.
//        ItemPerson person = new ItemPerson();

//        person.Email = "GBRITOS13@GMAIL.COM";
//        person.Name = "GUILLERMO";

//        result.StatusCode = System.Net.HttpStatusCode.OK;
//        result.Error = "null";
//        result.Success = true;

//    }


//    return result;
//}

//        [HttpPost]
//        [Route("api/people/newPeople")]
//        public async Task<PersonResults> PostPeople([FromBody] PersonDTO person)
//        {
//            var result = new PersonResults();

//            var peopleDto = new PersonDTO();

//            peopleDto.Name = person.Name;
//            peopleDto.SecondName = person.SecondName;


//            result.listPerson.Add(peopleDto);



//           await  context.AddAsync(peopleDto);
//            await context.SaveChangesAsync();



//        }


//        return result;
//    }
//}

//DATABASE FIRST COMMAND;

// dotnet ef dbcontext scaffol "Server=localhost;Port=5432;Database=Clase6;User Id=GuilleeBritos;Password=123456;" Npgsql.EntityFrameworkCore.PostgreSQL --output-dirModels


//TABLE VEHICULOS
//ID
//NOMBRE MODELO
//IDMARCA
//CANTIDAD PUERTAS
//FECHA ALTA
//FECHAMODIFICACION? NULL
//CANTIDADLITROSCOMBUSTIBLE


//TABLE MARCA
//ID
//NOMBRE MARCA


