using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTemplateEFCF.Models
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Libro> Libri { get; set; }
        public DbSet<Autore> Autori { get; set; }
        public DbSet<Editore> Editori { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlServer("Server=DESKTOP-7J82TJQ;Database=BibliotecaCF;Trusted_Connection=True;");
        }
    }
}
