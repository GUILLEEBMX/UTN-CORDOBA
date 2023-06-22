using APIModelFirst.DTOs;
using APIModelFirst.Entities;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace APIModelFirst.Business
{
    public class PeopleBusinessPut
    {
        public class PeopleCommandPut : IRequest<PeoplePutDTO>
        {
            public PeoplePutDTO PeoplePutDTO { get; set; }
            public PeopleCommandPut(PeoplePutDTO peoplePutDTO)
            {
                PeoplePutDTO = peoplePutDTO;
            }

        }

        public class ValidatePeoplePut : AbstractValidator<PeopleCommandPut>
        {

        }

        public class HandlerPeoplePut : IRequestHandler<PeopleCommandPut, PeoplePutDTO>
        {
            private readonly Clase6Context context;
            public HandlerPeoplePut(Clase6Context _context)
            {
                this.context = _context;

            }


            public async Task<PeoplePutDTO> Handle(PeopleCommandPut request, CancellationToken cancellationToken)
            {
                var people = await context.Personas.FirstOrDefaultAsync(x => x.Id == request.PeoplePutDTO.Id);

                if (people != null)
                {
                    Persona persona = new Persona();

                    persona.Name = request.PeoplePutDTO.Name;
                    persona.SecondName = request.PeoplePutDTO.SecondName;
                    persona.Age = request.PeoplePutDTO.Age;
                    persona.Idcategory = request.PeoplePutDTO.IdCategory;

                    context.Update(persona);
                    await context.SaveChangesAsync();

                    PeoplePutDTO peoplePut = new PeoplePutDTO();

                    peoplePut.Name = persona.Name;
                    peoplePut.SecondName = persona.SecondName;
                    peoplePut.Age = persona.Age;

                    return peoplePut;

                }

                return null;

            }
        }

    }
}
