using Shop.Mtg.Dominio;
using Shop.Mtg.Generica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Mtg.Dados.Entity.TypeConfiguration
{
    public class EdicaoTypeConfiguration : ShopEntityAbstractConfig<Edicao>
    {
        protected override void configurarNomeTabela()
        {
            ToTable("Edicao");
        }

        protected override void configurarChavePrimaria()
        {
            HasKey(pk => pk.Id);
        }

        protected override void configurarCamposTabela()
        {
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Nome");

            Property(p => p.Sigla)
                .IsRequired()
                .HasMaxLength(3)
                .HasColumnName("Sigla");

            Property(p => p.Ano)
                .IsRequired()
                .HasColumnName("Ano");
        }

        protected override void configurarChaveEstrangeira()
        {
            // Implementar quando houver chaves estrangeiras
        }
    }
}
