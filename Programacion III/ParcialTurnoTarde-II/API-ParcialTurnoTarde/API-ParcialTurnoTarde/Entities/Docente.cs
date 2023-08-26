using System;
using System.Collections.Generic;

namespace API_ParcialTurnoTarde.Entities
{
    public partial class Docente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public int Edad { get; set; }
        public string Email { get; set; } = null!;
        public int IdNivel { get; set; }

        public virtual Nivel IdNivelNavigation { get; set; } = null!;
    }
}
