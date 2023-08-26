using API_ParcialTurnoTarde.DTOs;
using API_ParcialTurnoTarde.Entities;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace API_ParcialTurnoTarde.Business
{
    public class BusinessDocenteGetAll
    {
        public class DocenteCommandGetAll : IRequest<List<DocenteDTO>>
        {

            public List<DocenteDTO> ListaDocentes { get; set; }

        }

        public class ValidateDoCenteCommandGetAll : AbstractValidator<DocenteCommandGetAll>
        {

        }

        public class HandlerDocenteGetAll : IRequestHandler<DocenteCommandGetAll, List<DocenteDTO>>
        {
            private readonly prog3_docentesContext context;

            public HandlerDocenteGetAll(prog3_docentesContext _context)
            {
                context = _context;
            }
            public async Task<List<DocenteDTO>> Handle(DocenteCommandGetAll request, CancellationToken cancellationToken)
            {
                var docentes = await context.Docentes.Where(x => x.IdNivelNavigation.Nombre == "Secundario" && x.Edad >= 30 && x.Edad <= 40 && x.Email == "outlook").Include(x => x.IdNivelNavigation).ToListAsync();

                if (docentes != null)
                {
                    List<DocenteDTO> listadocentes = new List<DocenteDTO>();


                    listadocentes.AddRange(docentes.Select(x => new DocenteDTO { Nombre = x.Nombre, Apellido = x.Apellido, Edad = x.Edad, Email = x.Email, Nivel = x.IdNivelNavigation.Nombre, Error = false, StatusCode = System.Net.HttpStatusCode.OK, Message = "OK" }));

                    return listadocentes;
                }



                return null;



            }
        }
    }

}
