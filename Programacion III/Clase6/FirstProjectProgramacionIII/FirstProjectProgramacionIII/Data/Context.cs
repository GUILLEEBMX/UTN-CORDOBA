using FirstProjectProgramacionIII.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FirstProjectProgramacionIII.Data
{
    public class Context :DbContext
    {


        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public virtual DbSet<Person> People { get; set; }


        public virtual DbSet<User> Users { get; set; }


        public virtual DbSet<Category> Category { get; set; }


        //5432 PORT DEFAULT.




        //SCAFFOLDING - 

        //dotnet tool install --global dotnet-ef

        // dotnet ef migrations add PrimeraMigracion
        // dotnet ef database update

    }
}
