using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PE.Application.StringConnection;
using PE.Domain.Entity.Alumno;
using PE.Domain.Entity.Empleado;
using PE.Domain.Entity.Empresa;
using PE.Domain.Entity.Galeria;
using PE.Domain.Entity.Persona;
using PE.Domain.Entity.Profesor;
using PE.Domain.Entity.Usuario;
using static PE.Application.StringConnection.StringConnection;

namespace PE.Infrastructure.Context
{
    public class ModelContext : DbContext
    {
        public ModelContext()
        {

        }

        public ModelContext(DbContextOptions<Context.ModelContext> option)
            : base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(StringConnection.GetStringConnectionWin);
            }
        }

        DbSet<Usuario> Usuario { get; set; }

        DbSet<Persona> Persona { get; set; }

        DbSet<Empresa> Empresa { get; set; }

        DbSet<Empleado> Empleado { get; set; }

        DbSet<Galeria> Galeria { get; set; }

        DbSet<Profesor> Profesor { get; set; }

        DbSet<Alumno> Alumno { get; set; }



    }
}
