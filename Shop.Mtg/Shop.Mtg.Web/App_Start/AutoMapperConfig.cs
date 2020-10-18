using AutoMapper;
using Shop.Mtg.Web.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Mtg.Web.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configurar()
        {
            Mapper.AddProfile<DominioToViewModelProfile>();
            Mapper.AddProfile<ViewModelToDominioProfile>();
        }
    }
}