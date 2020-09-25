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
    }
}
