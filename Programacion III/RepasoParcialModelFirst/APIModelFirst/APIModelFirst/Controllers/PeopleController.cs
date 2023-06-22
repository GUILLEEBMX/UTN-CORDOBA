using APIModelFirst.Business;
using APIModelFirst.DTOs;
using APIModelFirst.Entities;
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

        [HttpGet]
        [Route("api/people/{id}")]
        public async Task<ListPeopleDTO> GetPeopleId(int id)
        {

            var people = await mediator.Send(new PeopleBusinessGetId.PeopleCommandGetId(id));


            if (people == null)
            {
                ListPeopleDTO listPeople = new ListPeopleDTO();
                new ListPeopleDTO { Error = true, Message = "ERROR", StatusCode = System.Net.HttpStatusCode.NotFound };
                return listPeople;
            }

            people.Error = false;
            people.Message = "OK";
            people.StatusCode = System.Net.HttpStatusCode.OK;

            return people;

        }

        [HttpPost]
        [Route("api/people")]
        public async Task<ListPeopleDTO> CreatePeople([FromBody] PeoplePostDTO _people)
        {



            ListPeopleDTO listPeople = new ListPeopleDTO();
            var people = await mediator.Send(new PeopleBusinessPost.PeopleCommandPost(_people));


            if (people == null)
            {
                new ListPeopleDTO { Error = true, Message = "ERROR", StatusCode = System.Net.HttpStatusCode.BadRequest };
                return listPeople;
            }

            listPeople.Name = people.Name;
            listPeople.SecondName = people.SecondName;
            listPeople.Age = people.Age;
            listPeople.Error = false;
            listPeople.Message = "OK";
            listPeople.StatusCode = System.Net.HttpStatusCode.OK;



            return listPeople;

        }


        [HttpPut]
        [Route("api/people")]
        public async Task<ListPeopleDTO> UpdatePeople([FromBody] PeoplePutDTO _people)
        {



            ListPeopleDTO listPeople = new ListPeopleDTO();
            var people = await mediator.Send(new PeopleBusinessPut.PeopleCommandPut(_people));


            if (people == null)
            {
                new ListPeopleDTO { Error = true, Message = "ERROR", StatusCode = System.Net.HttpStatusCode.BadRequest };
                return listPeople;
            }

            listPeople.Name = people.Name;
            listPeople.SecondName = people.SecondName;
            listPeople.Age = people.Age;
            listPeople.Error = false;
            listPeople.Message = "OK";
            listPeople.StatusCode = System.Net.HttpStatusCode.OK;



            return listPeople;

        }


    }
}
