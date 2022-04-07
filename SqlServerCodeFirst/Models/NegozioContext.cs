using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerCodeFirst.Models
{
    // REGOLA N1: deve ereditare da DbContext!!!
    internal class NegozioContext : DbContext
    {
        public DbSet<Prodotto> Prodotti { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlServer("Server=DESKTOP-7J82TJQ;Database=Negozio;Trusted_Connection=True;");
        }
    }
}
