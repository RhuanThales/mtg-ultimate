using Shop.Mtg.Dados.Entity.TypeConfiguration;
using Shop.Mtg.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Mtg.Dados.Entity.Context
{
    public class MtgDbContext : DbContext
    {
        public DbSet<Carta> Cartas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CartaTypeConfiguration());
            // base.OnModelCreating(modelBuilder);
        }
    }
}
