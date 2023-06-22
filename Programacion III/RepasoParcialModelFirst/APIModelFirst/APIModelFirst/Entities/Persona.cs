using System;
using System.Collections.Generic;

namespace APIModelFirst.Entities;

public partial class Persona
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string SecondName { get; set; } = null!;

    public int Age { get; set; }

    public int Idcategory { get; set; }

    public virtual Category IdcategoryNavigation { get; set; } = null!;
}
