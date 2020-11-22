using Shop.Mtg.Dominio;
using Shop.Mtg.Generica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Mtg.Dados.Entity.TypeConfiguration
{
    class CartaTypeConfiguration : ShopEntityAbstractConfig<Carta>
    {
        protected override void configurarNomeTabela()
        {
            ToTable("Carta");
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

            Property(p => p.CustoMana)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("CustoMana");

            Property(p => p.CustoManaConvertido)
                .IsRequired()
                .HasColumnName("CustoManaConvertido");

            Property(p => p.Tipo)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Tipo");

            Property(p => p.Lendaria)
                .IsRequired()
                .HasColumnName("Lendaria");

            Property(p => p.SubTipoA)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("SubTipoA");

            Property(p => p.SubTipoB)
                .IsOptional()
                .HasMaxLength(50)
                .HasColumnName("SubTipoB");

            Property(p => p.Raridade)
                .IsRequired()
                .HasMaxLength(25)
                .HasColumnName("Raridade");

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(1000)
                .HasColumnName("Descricao");

            Property(p => p.Poder)
                .IsRequired()
                .HasColumnName("Poder");

            Property(p => p.Resistencia)
                .IsRequired()
                .HasColumnName("Resistencia");

            Property(p => p.IdEdicao)
               .IsRequired()
               .HasColumnName("IdEdicao");
        }

        protected override void configurarChaveEstrangeira()
        {
            HasRequired(p => p.Edicao)
                .WithMany(p => p.Cartas)
                .HasForeignKey(fk => fk.IdEdicao);
        }
    }
}
