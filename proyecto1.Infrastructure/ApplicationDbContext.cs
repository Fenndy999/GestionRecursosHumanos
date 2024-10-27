using Microsoft.EntityFrameworkCore;
using proyecto1.Domain;
using System.Collections.Generic;

namespace proyecto1.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<Salario> Salarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("TuCadenaDeConexion");
        }
    }
}