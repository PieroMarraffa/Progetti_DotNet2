using FatturazioneEfCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatturazioneEfCodeFirst
{
    internal class fatturazioneContext : DbContext
    {

        public DbSet<Cliente> Clienti { get; set; }
        public DbSet<Fattura> Fatture { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlServer("Server=DESKTOP-7J82TJQ;Database=Fatturazione;Trusted_Connection=True;");
        }
    }
}
