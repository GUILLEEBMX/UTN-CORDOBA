using APIModelFirst.DTOs;
using APIModelFirst.Entities;
using FluentValidation;
using MediatR;

namespace APIModelFirst.Business
{
    public class PeopleBusinessPost
    {
        public class PeopleCommandPost : IRequest<PeoplePostDTO>
        {
            public PeoplePostDTO PeoplePostDTO { get; set; }
            public PeopleCommandPost(PeoplePostDTO peoplePostDTO)
            {
                PeoplePostDTO = peoplePostDTO;
            }

        }

        public class ValidatePeoplePost : AbstractValidator<PeopleCommandPost>
        {

        }

        public class PeoplePostHandler : IRequestHandler<PeopleCommandPost, PeoplePostDTO>
        {
            private readonly Clase6Context context;
            public PeoplePostHandler(Clase6Context _context)
            {
                context = _context;
            }

            public async Task<PeoplePostDTO> Handle(PeopleCommandPost request, CancellationToken cancellationToken)
            {
                Persona persona = new Persona();
                PeoplePostDTO people = new PeoplePostDTO();

                persona.Name = request.PeoplePostDTO.Name;
                persona.SecondName = request.PeoplePostDTO.SecondName;
                persona.Age = request.PeoplePostDTO.Age;
                persona.Idcategory = request.PeoplePostDTO.IdCategory;

                await context.AddAsync(persona);

                await context.SaveChangesAsync();

                people.Name = request.PeoplePostDTO.Name;
                people.SecondName = request.PeoplePostDTO.SecondName;
                people.Age = request.PeoplePostDTO.Age;
          

                return people;


            }
        }



    }
}
