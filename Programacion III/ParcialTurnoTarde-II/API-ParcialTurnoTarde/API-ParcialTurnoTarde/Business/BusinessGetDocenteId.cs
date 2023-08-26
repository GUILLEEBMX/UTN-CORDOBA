using API_ParcialTurnoTarde.DTOs;
using API_ParcialTurnoTarde.Entities;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace API_ParcialTurnoTarde.Business
{
    public class BusinessGetDocenteId
    {
        public class DocenteGetIdCommand : IRequest<DocenteDTO>
        {
            public int Id { get; set; }

            public DocenteGetIdCommand(int id)
            {
                Id = id;
            }
        }

        public class ValidateDocenteGetIdCommand : AbstractValidator<DocenteGetIdCommand>
        {

        }

        public class HandlerDocenteGetId : IRequestHandler<DocenteGetIdCommand, DocenteDTO>
        {
            private readonly prog3_docentesContext context;

            public HandlerDocenteGetId(prog3_docentesContext context)
            {
                this.context = context;
            }

            public async Task<DocenteDTO> Handle(DocenteGetIdCommand request, CancellationToken cancellationToken)
            {
                var docente = await context.Docentes.Where(x => x.IdNivelNavigation.Nombre == "Secundario" && x.Edad >= 30 && x.Edad <= 40 && x.Email == "outlook").Include(x => x.IdNivelNavigation).FirstOrDefaultAsync(x => x.Id == request.Id);

                if(docente == null)
                {
                    return null;
                }

                DocenteDTO docenteDTO = new DocenteDTO();

                docenteDTO.Id = docente.Id;
                docenteDTO.Nombre = docente.Nombre;
                docenteDTO.Apellido = docente.Apellido;
                docenteDTO.Edad = docente.Edad;
                docenteDTO.Email = docente.Email;
                docenteDTO.Nivel = docente.IdNivelNavigation.Nombre;

                return docenteDTO;

          
            }
        }


    }
}
