using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace API_ParcialTurnoTarde.Entities
{
    public partial class prog3_docentesContext : DbContext
    {
        public prog3_docentesContext()
        {
        }

        public prog3_docentesContext(DbContextOptions<prog3_docentesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Docente> Docentes { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<Nivel> Nivels { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=138.99.7.66;Port=5432;Database=prog3_docentes;User Id=prog3_tema1;Password=123456Tup;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Docente>(entity =>
            {
                entity.HasIndex(e => e.IdNivel, "fki_nivel");

                entity.Property(e => e.Id).UseIdentityAlwaysColumn();

                entity.HasOne(d => d.IdNivelNavigation)
                    .WithMany(p => p.Docentes)
                    .HasForeignKey(d => d.IdNivel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("nivel");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.Property(e => e.Id).UseIdentityAlwaysColumn();

                entity.Property(e => e.Log1).HasColumnName("Log");
            });

            modelBuilder.Entity<Nivel>(entity =>
            {
                entity.ToTable("Nivel");

                entity.Property(e => e.Id).UseIdentityAlwaysColumn();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
