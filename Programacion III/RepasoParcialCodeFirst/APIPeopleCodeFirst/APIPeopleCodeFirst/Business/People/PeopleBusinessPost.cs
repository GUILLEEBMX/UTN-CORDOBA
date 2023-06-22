using APIPeopleCodeFirst.Data;
using APIPeopleCodeFirst.Models;
using APIPeopleCodeFirst.Result.PeopleResult;
using FluentValidation;
using MediatR;

namespace APIPeopleCodeFirst.Business.People
{
    public class PeopleBusinessPost
    {
        public class PeopleCommand : IRequest<PeopleResult>
        {
            public PeoplePostResult People { get; set; }

            public PeopleCommand(PeoplePostResult people)
            {
                People = people;

            }
        }

        public class ValidatePost : AbstractValidator<PeopleCommand>
        {

        }


        public class Handler : IRequestHandler<PeopleCommand, PeopleResult>
        {
            private readonly Context context;
            public Handler(Context _context)
            {
                context = _context;
            }
            public async Task<PeopleResult> Handle(PeopleCommand request, CancellationToken cancellationToken)
            {
                PeopleModel persona = new PeopleModel();


                persona.Name = request.People.Name;
                persona.SecondName = request.People.SecondName;
                persona.Age = request.People.Age;
                persona.idcategory = request.People.IdCategory;

                var result = await context.People.AddAsync(persona);

                await context.SaveChangesAsync();

                PeopleResult peopleList = new PeopleResult();

                ItemPeople itemPeople = new ItemPeople();

                itemPeople.Name = persona.Name;
                itemPeople.SecondName = persona.SecondName;
                itemPeople.Age = persona.Age;
                itemPeople.IdCategory = persona.idcategory;

                peopleList.People.Add(itemPeople);

                return peopleList;
            }
        }
    }
}
