using System;
using System.Collections.Generic;

namespace API_ParcialTurnoTarde.Entities
{
    public partial class Log
    {
        public int Id { get; set; }
        public DateOnly FechaLog { get; set; }
        public string Log1 { get; set; } = null!;
        public int IdDocente { get; set; }
    }
}
