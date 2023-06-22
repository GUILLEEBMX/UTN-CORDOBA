using APIPeopleCodeFirst.Data;
using APIPeopleCodeFirst.Result.PeopleResult;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace APIPeopleCodeFirst.Business.People
{
    public class PeopleBusiness
    {
        public class PeopleComando : IRequest<PeopleResult>
        {

            public List<PeopleResult> people { get; set; }

        }

        public class ValidationPeople : AbstractValidator<PeopleComando>
        {

        }

        public class Manejador : IRequestHandler<PeopleComando, PeopleResult>
        {
            private readonly Context context;
            public Manejador(Context _context)
            {
                this.context = _context;
            }
            public async Task<PeopleResult> Handle(PeopleComando request, CancellationToken cancellationToken)
            {

                var result = await context.People.Include(x => x.category).ToListAsync();

                PeopleResult people = new PeopleResult();

                for (int i = 0; i < result.Count; i++)
                {


                    ItemPeople peopleItem = new ItemPeople();

                    peopleItem.Name = result[i].Name;
                    peopleItem.SecondName = result[i].SecondName;
                    peopleItem.Age = result[i].Age;
                    peopleItem.IdCategory = result[i].idcategory;
                    peopleItem.Category.Name = result[i].category.Name;

                    people.People.Add(peopleItem);


                }

                return people;

            }
        }
    }
}
