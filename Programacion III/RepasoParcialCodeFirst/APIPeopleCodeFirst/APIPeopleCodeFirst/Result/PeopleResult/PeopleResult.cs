using APIPeopleCodeFirst.Models;

namespace APIPeopleCodeFirst.Result.PeopleResult
{
    public class PeopleResult : ResultBase
    {
        public List<ItemPeople> People { get; set; } = new List<ItemPeople>();

    }

    public class ItemPeople
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public int IdCategory   { get; set; }

        public Category Category { get; set; } = new Category();
    }
}
