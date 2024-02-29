using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2.Models
{
    public class LibreriaDbContext : DbContext
    {
        public virtual DbSet<Libro> Libros { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");
                var configuracion = builder.Build();
                optionsBuilder.UseLazyLoadingProxies()
                    .UseSqlServer(configuracion["ConnectionStrings:MiConexion"]);
            }
        }
    }
}
