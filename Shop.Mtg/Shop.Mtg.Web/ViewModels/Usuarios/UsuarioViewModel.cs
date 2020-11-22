using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.Mtg.Web.ViewModels.Usuarios
{
    public class UsuarioViewModel
    {
        [Required(ErrorMessage = "O e-mail e obrigatorio")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha e obrigatoria")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}