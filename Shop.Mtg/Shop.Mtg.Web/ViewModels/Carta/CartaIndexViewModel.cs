using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.Mtg.Web.ViewModels.Carta
{
    public class CartaIndexViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome da Carta")]
        public string Nome { get; set; }

        [Display(Name = "Custo de Mana")]
        public string CustoMana { get; set; }

        [Display(Name = "Custo de Mana Convertido")]
        public int CustoManaConvertido { get; set; }

        [Display(Name = "Tipo da Carta")]
        public string Tipo { get; set; }

        [Display(Name = "Lendária")]
        public bool Lendaria { get; set; }

        [Display(Name = "Raça")]
        public string SubTipoA { get; set; }

        [Display(Name = "Classe")]
        public string SubTipoB { get; set; }

        [Display(Name = "Raridade da Carta")]
        public string Raridade { get; set; }

        [Display(Name = "Descrição da Carta")]
        public string Descricao { get; set; }

        [Display(Name = "Poder da Carta")]
        public int Poder { get; set; }

        [Display(Name = "Resistência da Carta")]
        public int Resistencia { get; set; }

        [Display(Name = "Edição da Carta")]
        public string IdEdicao { get; set; }

        [Display(Name = "Edição")]
        public string EdicaoNome { get; set; }
    }
}