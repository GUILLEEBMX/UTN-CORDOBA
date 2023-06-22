using APIModelFirst.DTOs;
using APIModelFirst.Entities;
using APIModelFirst.Result;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace APIModelFirst.Business
{
    public class PeopleBusinessGetAll
    {
        public class PeopleCommandGetAll : IRequest<List<ListPeopleDTO>>
        {
            public List<ListPeopleDTO> ListPeopleDTO { get; set; }

        }

        public class ValidateGetAll : AbstractValidator<PeopleCommandGetAll>
        {

        }

        public class HandlerPeopleGetAll : IRequestHandler<PeopleCommandGetAll, List<ListPeopleDTO>>
        {
            private readonly Clase6Context context;

            public HandlerPeopleGetAll(Clase6Context context)
            {
                this.context = context;
            }

            public async Task<List<ListPeopleDTO>> Handle(PeopleCommandGetAll request, CancellationToken cancellationToken)
            {
                List<ListPeopleDTO> people = new List<ListPeopleDTO>();

                var result = await context.Personas.ToListAsync();


                people.AddRange(result.Select(x => new ListPeopleDTO { Name = x.Name, SecondName = x.SecondName, Age = x.Age }));

                return people;


            }
        }
    }
}
