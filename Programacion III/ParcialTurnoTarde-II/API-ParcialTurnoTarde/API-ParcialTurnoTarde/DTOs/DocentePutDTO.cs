namespace API_ParcialTurnoTarde.DTOs
{
    public class DocentePutDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public int Edad { get; set; }
        public string Email { get; set; } = null!;
    }
}
