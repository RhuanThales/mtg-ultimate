using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.Mtg.Web.ViewModels.Edicao
{
    public class EdicaoViewModel
    {
        [Required(ErrorMessage = "O Id é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MaxLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres")]
        [Display(Name = "Nome da edição")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A sigla é obrigatório")]
        [MaxLength(3, ErrorMessage = "O nome deve ter no máximo 3 caracteres")]
        [Display(Name = "Sigla da edição")]
        public string Sigla { get; set; }

        [Required(ErrorMessage = "O ano é obrigatório")]
        [Display(Name = "Ano da edição")]
        public int Ano { get; set; }
    }
}