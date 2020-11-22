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
    public class EdicoesRepositorio : RepositorioGenericoEntity<Edicao, int>
    {
        public EdicoesRepositorio(MtgDbContext contexto)
            : base(contexto)
        {

        }

        public override List<Edicao> Selecionar()
        {
            return _contexto.Set<Edicao>().Include(p => p.Cartas).ToList();
        }

        public override Edicao SelecionarPorId(int id)
        {
            return _contexto.Set<Edicao>().Include(p => p.Cartas)
                .SingleOrDefault(a => a.Id == id);
        }
    }
}
