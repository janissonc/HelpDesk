using HelpDesk.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.DAL
{
    public class AppDbContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=Helpdesk;Integrated Security=True;User ID=sa;Password=1234;");
        }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Incidente> Incidentes { get; set; }
        public DbSet<Prioridade> Priooridades { get; set; }
        public DbSet<Recurso> Recursos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
