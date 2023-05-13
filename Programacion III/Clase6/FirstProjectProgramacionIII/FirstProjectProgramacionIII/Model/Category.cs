using FirstProjectProgramacionIII.Controllers;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstProjectProgramacionIII.Model
{

    [Table("Categories")]
    public class Category
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public Person Person { get; set; }

    }


}
