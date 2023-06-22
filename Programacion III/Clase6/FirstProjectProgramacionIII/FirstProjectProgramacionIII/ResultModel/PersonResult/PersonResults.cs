using System.Linq.Expressions;
using System.Net;

namespace FirstProjectProgramacionIII.ResultModel.PersonResult
{
    public class PersonResults  
    {

        public PersonResults()
        {
            listPerson = new List<ItemPerson>();
        }

        public List<ItemPerson>listPerson { get; set; }


    }


    public class ItemPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        //propertie categorie


        


    }

}
