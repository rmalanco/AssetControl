using AssetControl.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssetControl.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly string dataBase = "AssetControl.db";
        public DbSet<Usuario>? Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString: $"filename={dataBase}",
                sqliteOptionsAction: options =>
                {
                    options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
                });


            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Tabla Usuarios
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");
            modelBuilder.Entity<Usuario>().HasKey(x => x.IdUsuario);
            modelBuilder.Entity<Usuario>().Property(x => x.UserName).IsRequired();
            modelBuilder.Entity<Usuario>().Property(x => x.Password).IsRequired();
            modelBuilder.Entity<Usuario>().Property(x => x.FechaRegistro).IsRequired();
            modelBuilder.Entity<Usuario>().Property(x => x.FechaModificacion).IsRequired();
            modelBuilder.Entity<Usuario>().Property(x => x.Activo).IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
