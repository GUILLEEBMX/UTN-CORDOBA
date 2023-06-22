using APIModelFirst.Business;
using APIModelFirst.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace APIModelFirst.Controllers
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
        [Route("api/people")]
        public async Task<List<ListPeopleDTO>> GetAllPeople()
        {

            var people = await mediator.Send(new PeopleBusinessGetAll.PeopleCommandGetAll());

            if (people == null)
            {
                List<ListPeopleDTO> listPeople = new List<ListPeopleDTO>();
                listPeople.Add(new ListPeopleDTO { Error = true, Message = "ERROR", StatusCode = System.Net.HttpStatusCode.NotFound });
                return listPeople;
            }


            return people;

        }


    }
}
