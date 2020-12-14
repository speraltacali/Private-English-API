using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PE.Application.StringConnection;
using PE.Domain.Entity.Usuario;
using System;
using System.Collections.Generic;
using System.Text;
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



    }
}
