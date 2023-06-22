using APIModelFirst.DTOs;
using APIModelFirst.Entities;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace APIModelFirst.Business
{
    public class PeopleBusinessGetId
    {
        public class PeopleCommandGetId : IRequest<ListPeopleDTO>
        {
            public int Id { get; set; }
            public PeopleCommandGetId(int id)
            {
                Id = id;
            }


        }

        public class ValidatePeopleGetId : AbstractValidator<PeopleBusinessGetId>
        {

        }

        public class HandlerPeopleGetId : IRequestHandler<PeopleCommandGetId, ListPeopleDTO>
        {
            private readonly Clase6Context context;
            public HandlerPeopleGetId(Clase6Context _context)
            {
                context = _context;
            }
            public async Task<ListPeopleDTO> Handle(PeopleCommandGetId request, CancellationToken cancellationToken)
            {
                var result = await context.Personas.FirstOrDefaultAsync(x => x.Id == request.Id);

                ListPeopleDTO peopleList = new ListPeopleDTO();

                peopleList.Name = result.Name;
                peopleList.SecondName = result.SecondName;
                peopleList.Age = result.Age;

                return peopleList;



            }
        }



    }
}
