using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateConsoleEFCF.Models
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Classe> Classe { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlServer("Server=DESKTOP-7J82TJQ;Database=nomeDB;Trusted_Connection=True;");
        }
    }
}
