using APIPeopleCodeFirst.Data;
using APIPeopleCodeFirst.Models;
using APIPeopleCodeFirst.Result.PeopleResult;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace APIPeopleCodeFirst.Business.People
{
    public class PeopleBusinessPut
    {
        public class PeoplePutCommand : IRequest<PeopleResult>
        {
            public PeoplePutDTO PeoplePutDTO { get; set; }

            public PeoplePutCommand(PeoplePutDTO people)
            {
                PeoplePutDTO = people;
            }


        }

        public class ValidatePeoplePut : AbstractValidator<PeopleResult>
        {

        }

        public class HandlerPeoplePut : IRequestHandler<PeoplePutCommand, PeopleResult>
        {
            private readonly Context context;
            public HandlerPeoplePut(Context _context)
            {
                context = _context;

            }
            public async Task<PeopleResult> Handle(PeoplePutCommand request, CancellationToken cancellationToken)
            {
                PeopleResult listPeopleResult = new PeopleResult();

                var people = await context.People.FirstOrDefaultAsync(x => x.Id == request.PeoplePutDTO.Id);

                if (people != null)
                {
                    listPeopleResult.Error = "ERROR";
                    listPeopleResult.Message = "LA PERSONA NO EXISTE...";
                    listPeopleResult.StatusCode = System.Net.HttpStatusCode.NotFound;


                }


                people.Name = request.PeoplePutDTO.Name;
                people.SecondName = request.PeoplePutDTO.SecondName;
                people.Age = request.PeoplePutDTO.Age;

                var result = context.Update(people);

                await context.SaveChangesAsync();


                ItemPeople itemPeople = new ItemPeople();

                itemPeople.Name = people.Name;
                itemPeople.SecondName = people.SecondName;
                itemPeople.Age = people.Age;

                listPeopleResult.People.Add(itemPeople);

                return listPeopleResult;


            }
        }

    }
}
