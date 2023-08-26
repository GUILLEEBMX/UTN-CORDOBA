using API_ParcialTurnoTarde.Entities;
using API_ParcialTurnoTarde.Result;

namespace API_ParcialTurnoTarde.DTOs
{
    public class DocenteDTO : ResultBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public int Edad { get; set; }
        public string Email { get; set; } = null!;
        public  string Nivel { get; set; } = null!;

    }
}

