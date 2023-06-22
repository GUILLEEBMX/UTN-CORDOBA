using APIPeopleCodeFirst.Business.People;
using APIPeopleCodeFirst.Models;
using APIPeopleCodeFirst.Result.PeopleResult;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace APIPeopleCodeFirst.Controllers
{
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IMediator mediator;
        public PeopleController(IMediator _mediator)
        {
            mediator = _mediator;
        }

        [HttpGet]
        [Route("api/people/getAllPeople")]
        public async Task<PeopleResult> GetAllPeople()
        {

            var result = await mediator.Send(new PeopleBusiness.PeopleComando());

            if (result != null)
            {
                result.Message = "OK";
                result.StatusCode = System.Net.HttpStatusCode.OK;
                result.Error = null;

                return result;
            }



            result.Message = "NOT PEOPLE FOUND";
            result.StatusCode = System.Net.HttpStatusCode.NotFound;
            result.Error = null;

            return result;



        }

        [HttpGet]
        [Route("api/people/getIdPeople/{id}")]
        public async Task<PeopleResult> GetIdPeople(int id)
        {

            var result = await mediator.Send(new PeopleBusinessGetId.PeopleByIdCommand(id));

            if (result != null)
            {
                result.Message = "OK";
                result.StatusCode = System.Net.HttpStatusCode.OK;
                result.Error = null;

                return result;
            }



            result.Message = "NOT PEOPLE FOUND";
            result.StatusCode = System.Net.HttpStatusCode.NotFound;
            result.Error = null;

            return result;



        }

        [HttpPost]
        [Route("api/people")]
        public async Task<PeopleResult> CreatePeople([FromBody] PeoplePostResult people)
        {

            var result = await mediator.Send(new PeopleBusinessPost.PeopleCommand(people));

            if (result != null)
            {
                result.Message = "OK";
                result.StatusCode = System.Net.HttpStatusCode.OK;
                result.Error = null;

                return result;
            }



            result.Message = "ERROR TO INSERT PEOPLE";
            result.StatusCode = System.Net.HttpStatusCode.NotFound;
            result.Error = null;

            return result;



        }

        [HttpPut]
        [Route("api/people/put")]
        public async Task<PeopleResult> UpdatePeople([FromBody] PeoplePutDTO people)
        {

            var result = await mediator.Send(new PeopleBusinessPut.PeoplePutCommand(people));

            if (result != null)
            {
                result.Message = "OK";
                result.StatusCode = System.Net.HttpStatusCode.OK;
                result.Error = null;

                return result;
            }



            result.Message = "ERROR TO INSERT PEOPLE";
            result.StatusCode = System.Net.HttpStatusCode.NotFound;
            result.Error = null;

            return result;



        }


    }
}
