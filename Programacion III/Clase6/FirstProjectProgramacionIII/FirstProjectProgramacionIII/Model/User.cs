using System.ComponentModel.DataAnnotations.Schema;

namespace FirstProjectProgramacionIII.Model
{


    [Table("Users")]
    public class User
    {


        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
