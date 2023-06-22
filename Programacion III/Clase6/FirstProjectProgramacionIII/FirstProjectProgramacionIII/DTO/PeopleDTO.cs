using FirstProjectProgramacionIII.ResultModel;

namespace FirstProjectProgramacionIII.DTO
{
    public class PeopleDTO 
    {
        public string Name { get; set; }

        public string SecondName { get; set; }

        public PeopleDTO(string name, string secondName)
        {
            this.Name = name;
            this.SecondName = secondName;   

        }

        public PeopleDTO()
        {

        }

    }
}
