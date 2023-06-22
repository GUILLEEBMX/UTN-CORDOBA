using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace APIModelFirst.Entities;

public partial class Clase6Context : DbContext
{
    public Clase6Context()
    {
    }

    public Clase6Context(DbContextOptions<Clase6Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Clase6;User Id=GuilleeBritos;Password=123456;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasIndex(e => e.Idcategory, "IX_Personas_idcategory");

            entity.Property(e => e.Idcategory).HasColumnName("idcategory");

            entity.HasOne(d => d.IdcategoryNavigation).WithMany(p => p.Personas).HasForeignKey(d => d.Idcategory);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
