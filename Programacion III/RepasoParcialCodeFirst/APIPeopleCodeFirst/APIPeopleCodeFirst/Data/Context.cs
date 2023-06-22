using APIPeopleCodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace APIPeopleCodeFirst.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<PeopleModel> People { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuraciones adicionales

            base.OnModelCreating(modelBuilder);
        }
    }


}
