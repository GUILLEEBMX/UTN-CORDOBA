using API_ParcialTurnoTarde.Business;
using API_ParcialTurnoTarde.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API_ParcialTurnoTarde.Controllers
{
    public class DocenteController : ControllerBase
    {
        private readonly IMediator mediator;
        public DocenteController(IMediator _mediator)
        {
            mediator = _mediator;

        }

        [HttpGet]
        [Route("api/docentes")]
        public async Task<List<DocenteDTO>> ObtenerTodosLosDocentes()
        {
            var docentes = await mediator.Send(new BusinessDocenteGetAll.DocenteCommandGetAll());

            List<DocenteDTO> listadoDocentes = new List<DocenteDTO>();


            if (docentes == null)
            {

                listadoDocentes.Add(new DocenteDTO { Error = true, Message = "Ha Ocurrido un Error", StatusCode = System.Net.HttpStatusCode.NotFound });
                return listadoDocentes;
            }


            return docentes;

        }

        [HttpGet]
        [Route("api/docentes/{id}")]
        public async Task<DocenteDTO> ObtenerDocente(int id )
        {
            var docente = await mediator.Send(new BusinessGetDocenteId.DocenteGetIdCommand(id));


            if (docente == null)
            {

                return new DocenteDTO { Error = true, Message = "Ha Ocurrido un Error", StatusCode = System.Net.HttpStatusCode.NotFound };
        
            }


            return docente;

        }

        [HttpPut]
        [Route("api/docentes/{id}")]
        public async Task<DocenteDTO> ActualizarUnDocente(int id,[FromBody] DocentePutDTO docente)
        {
            DocenteDTO docenteDTO = new DocenteDTO();

            var result = await mediator.Send(new BusinessDocentePut.DocenteCommandPut(id,docente));



            if (result == null)
            {

                docenteDTO.Error = true;
                docenteDTO.Message = "EL DOCENTE QUE INTENTA ACTUALIZAR NO EXISTE O EL QUE ENVIO ES NULO";
                docenteDTO.StatusCode = System.Net.HttpStatusCode.NotFound;

                return docenteDTO;

            }

            docenteDTO.Error = false;
            docenteDTO.Message = "OK";
            docenteDTO.StatusCode = System.Net.HttpStatusCode.OK;
            docenteDTO.Nombre = docente.Nombre;
            docenteDTO.Apellido = docente.Apellido;
            docenteDTO.Email = docente.Email;
            docenteDTO.Edad = docente.Edad;

            return docenteDTO;

        }



    }


}
