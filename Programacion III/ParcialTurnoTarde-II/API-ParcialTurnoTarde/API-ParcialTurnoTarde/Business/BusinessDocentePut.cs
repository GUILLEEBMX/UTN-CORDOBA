using API_ParcialTurnoTarde.DTOs;
using API_ParcialTurnoTarde.Entities;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace API_ParcialTurnoTarde.Business
{
    public class BusinessDocentePut
    {
        public class DocenteCommandPut : IRequest<DocentePutDTO>
        {
            public DocentePutDTO DocentePutDTO { get; set; }
            public int Id { get; set; }
            public DocenteCommandPut(int id, DocentePutDTO docentePutDTO)
            {
                this.DocentePutDTO = docentePutDTO;
                Id = id;
            }

            public class ValidateDocenteCommandPut : AbstractValidator<DocenteCommandPut>
            {

                public ValidateDocenteCommandPut()
                {


                    RuleFor(x => x.DocentePutDTO).NotNull().WithMessage("DEBE ENVIAR UNA PERSONA PARA ACTUALIZAR");
                    RuleFor(x => x.Id).NotEmpty().WithMessage("DEBE ENVIAR EL ID PARA ACTUALIZAR");
                }

            }

            public class HandlerDocentePut : IRequestHandler<DocenteCommandPut, DocentePutDTO>
            {
                private readonly prog3_docentesContext context;
                private readonly IValidator<DocenteCommandPut> validator;

                public HandlerDocentePut(prog3_docentesContext context, IValidator<DocenteCommandPut> _validator)
                {
                    this.context = context;
                    this.validator = _validator;
                }
                public async Task<DocentePutDTO> Handle(DocenteCommandPut request, CancellationToken cancellationToken)
                {

                    var validation = await validator.ValidateAsync(request);

                    if (!validation.IsValid)
                    {
                        var errors = string.Join(Environment.NewLine, validation.Errors);
                        return null;
                    }

                    var people = await context.Docentes.FirstOrDefaultAsync(x => x.Id == request.DocentePutDTO.Id);

                    if (people == null)
                    {
                        return null;
                    }

                    Docente docente = new Docente();


                    docente.Nombre = request.DocentePutDTO.Nombre;
                    docente.Apellido = request.DocentePutDTO.Apellido;
                    docente.Edad = request.DocentePutDTO.Edad;
                    docente.Email = request.DocentePutDTO.Email;
                    docente.IdNivel = people.IdNivel;


                    context.Update(docente);
                    await context.SaveChangesAsync();


                    Log log = new Log();

                    log.FechaLog = DateOnly.FromDateTime(DateTime.Now);
                    log.Log1 = "TEST TEST";
                    log.IdDocente = people.Id;

                    await context.AddAsync(log);
                    await context.SaveChangesAsync();

                    DocentePutDTO docentePutDTO = new DocentePutDTO();

                    docentePutDTO.Nombre = docente.Nombre;
                    docentePutDTO.Apellido = docente.Apellido;
                    docentePutDTO.Edad = docente.Edad;
                    docentePutDTO.Email = docente.Email;



                    return docentePutDTO;
                }
            }
        }
    }
}
