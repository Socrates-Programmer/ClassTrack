using ClassTrack.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClassTrack.Persistence.Contexts
{
    public class DbUniversidadContext : DbContext
    {

        public DbSet<AreaConocimiento> AreaConocimientos { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Docencia> Docencias { get; set; }
        public DbSet<EquivalenciaAsignatura> EquivalenciaAsignaturas { get; set; }
        public DbSet<Grupos> Grupos { get; set; }
        public DbSet<HorarioConsulta> HorarioConsultas { get; set; }
        public DbSet<IncompatibilidadAsignatura> IncompatibilidadAsignaturas { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Titulacion> Titulaciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Universidad;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Docencia>()
                .HasOne(d => d.Profesor)
                .WithMany(p => p.Docencias)
                .HasForeignKey(d => d.ProfesorID)
                .OnDelete(DeleteBehavior.Restrict); // evita la cascada

            modelBuilder.Entity<Docencia>()
                .HasOne(d => d.Asignatura)
                .WithMany(a => a.Docencias)
                .HasForeignKey(d => d.AsignaturaID)
                .OnDelete(DeleteBehavior.Restrict); // evita la cascada también

        }
    }
}
