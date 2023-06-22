using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIPeopleCodeFirst.Models
{
    [Table("Personas")]
    public class PeopleModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }

        public int idcategory { get; set; }

        [ForeignKey("idcategory")]
        public Category category { get; set; }


    }
}
