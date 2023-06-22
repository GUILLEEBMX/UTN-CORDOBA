using APIPeopleCodeFirst.Data;
using APIPeopleCodeFirst.Result.PeopleResult;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace APIPeopleCodeFirst.Business.People
{
    public class PeopleBusinessGetId
    {
        public class PeopleByIdCommand : IRequest<PeopleResult>
        {
            public int Id { get; set; }
            public PeopleByIdCommand(int _Id)
            {
                Id = _Id;

            }
            public PeopleResult People { get; set; }
        }


        public class ValidateGetIdPeople : AbstractValidator<PeopleByIdCommand>
        {

        }

        public class Manejador : IRequestHandler<PeopleByIdCommand, PeopleResult>
        {
            private readonly Context context;

            public Manejador(Context _context)
            {
                context = _context;
            }

            public async Task<PeopleResult> Handle(PeopleByIdCommand request, CancellationToken cancellationToken)
            {

                //var result = await context.People.FirstOrDefaultAsync(x => x.Id == request.People.People[0].Id);


                var result = await context.People.Where(c => c.Id == request.Id).Include(x => x.category).FirstOrDefaultAsync();

                PeopleResult people = new PeopleResult();

                ItemPeople peopleItem = new ItemPeople();

                peopleItem.Name = result.Name;
                peopleItem.SecondName = result.SecondName;
                peopleItem.Age = result.Age;
                peopleItem.IdCategory = result.idcategory;
                peopleItem.Category.Name = result.category.Name;

                people.People.Add(peopleItem);

                return people;


            }
        }
    }


}
