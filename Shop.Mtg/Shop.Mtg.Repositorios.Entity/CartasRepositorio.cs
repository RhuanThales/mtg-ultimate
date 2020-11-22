using Shop.Mtg.Dados.Entity.Context;
using Shop.Mtg.Dominio;
using Shop.Mtg.Repositorios.Comum.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Shop.Mtg.Repositorios.Entity
{
    public class CartasRepositorio : RepositorioGenericoEntity<Carta, long>
    {
        public CartasRepositorio(MtgDbContext contexto)
            : base(contexto)
        {

        }

        public override List<Carta> Selecionar()
        {
            return _contexto.Set<Carta>().Include(p => p.Edicao).ToList();
        }

        public override Carta SelecionarPorId(long id)
        {
            return _contexto.Set<Carta>().Include(p => p.Edicao)
                .SingleOrDefault(e => e.IdEdicao == id);
        }
    }
}
