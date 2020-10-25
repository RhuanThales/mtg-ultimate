using Shop.Mtg.Web.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.Mtg.Web.ViewModels.Carta
{
    public class CartaViewModel
    {
        [Required(ErrorMessage = "O id é Obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é Obrigatório")]
        [MaxLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres")]
        [Display(Name = "Nome da Carta")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo custo de mana é Obrigatório")]
        [MaxLength(50, ErrorMessage = "O custo de mana deve ter no máximo 50 caracteres")]
        [Display(Name = "Custo de Mana")]
        public string CustoMana { get; set; }

        [Required(ErrorMessage = "O campo custo de mana convertido é Obrigatório")]
        [Display(Name = "Custo de Mana Convertido")]
        public int CustoManaConvertido { get; set; }

        [Required(ErrorMessage = "O campo tipo é Obrigatório")]
        [MaxLength(50, ErrorMessage = "O tipo da carta deve ter no máximo 50 caracteres")]
        [Display(Name = "Tipo da Carta")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Deve-se indicar se é Lendária")]
        [Display(Name = "Lendária")]
        public bool Lendaria { get; set; }

        [Required(ErrorMessage = "O campo raça é Obrigatório")]
        [MaxLength(50, ErrorMessage = "A raça deve ter no máximo 50 caracteres")]
        [Display(Name = "Raça")]
        public string SubTipoA { get; set; }

        [MaxLength(50, ErrorMessage = "A classe deve ter no máximo 50 caracteres")]
        [Display(Name = "Classe")]
        public string SubTipoB { get; set; }

        [Required(ErrorMessage = "O campo raridade é Obrigatório")]
        [MaxLength(50, ErrorMessage = "A raridade deve ter no máximo 50 caracteres")]
        [Display(Name = "Raridade da Carta")]
        public string Raridade { get; set; }

        [Required(ErrorMessage = "O campo descrição é Obrigatório")]
        [MaxLength(1000, ErrorMessage = "A descrição deve ter no máximo 1000 caracteres")]
        [Display(Name = "Descrição da Carta")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo poder é Obrigatório")]
        [Display(Name = "Poder da Carta")]
        public int Poder { get; set; }

        [Required(ErrorMessage = "O campo resistência é Obrigatório")]
        [Display(Name = "Resistência da Carta")]
        public int Resistencia { get; set; }

        [MaxLength(100, ErrorMessage = "A edição deve ter no máximo 100 caracteres")]
        [Display(Name = "Edição da Carta")]
        [Edicao(ErrorMessage = "A edição deve começar com a sigla 'MTG'")]
        public string Edicao { get; set; }
    }
}