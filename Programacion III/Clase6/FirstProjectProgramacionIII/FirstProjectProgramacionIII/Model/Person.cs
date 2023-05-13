using System.ComponentModel.DataAnnotations.Schema;

namespace FirstProjectProgramacionIII.Model
{

    [Table("People")]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string SecondName { get; set; }

        public DateTime Date { get; set; }


        public DateTime? DateModified { get; set; }

        public int IdCategory { get; set; }

        //[ForeignKey("IdCategory")]


    }

    
}
