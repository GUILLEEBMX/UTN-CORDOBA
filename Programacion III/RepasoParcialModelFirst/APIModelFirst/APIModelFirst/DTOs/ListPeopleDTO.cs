using APIModelFirst.Result;

namespace APIModelFirst.DTOs
{
    public class ListPeopleDTO : ResultBase
    {
        public string Name { get; set; }
      
        public string SecondName { get; set; }

        public int Age { get; set; }
    }
}
