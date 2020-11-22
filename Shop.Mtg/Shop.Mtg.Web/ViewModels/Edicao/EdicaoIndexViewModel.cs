using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.Mtg.Web.ViewModels.Edicao
{
    public class EdicaoIndexViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome da edição")]
        public string Nome { get; set; }

        [Display(Name = "Sigla da edição")]
        public string Sigla { get; set; }

        [Display(Name = "Ano da Edição")]
        public int Ano { get; set; }
    }
}