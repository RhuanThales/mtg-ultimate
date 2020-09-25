using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Mtg.Generica.Entity
{
    public abstract class ShopEntityAbstractConfig<TEntidade> : EntityTypeConfiguration<TEntidade>
        where TEntidade : class
    {
        public ShopEntityAbstractConfig()
        {
            configurarNomeTabela();
            configurarCamposTabela();
            configurarChavePrimaria();
            configurarChaveEstrangeira();
        }

        protected abstract void configurarNomeTabela();
        protected abstract void configurarCamposTabela();
        protected abstract void configurarChavePrimaria();
        protected abstract void configurarChaveEstrangeira();
    }
}
