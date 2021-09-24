using HelpDesk.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.DAL
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) { }
        public DbSet<Incidente> Incidentes { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Prioridade> Prioridades { get; set; }
        public DbSet<Recurso> Recursos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", false, true)
            .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ServerConnection"));
        }
    }
}
