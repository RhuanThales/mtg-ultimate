using AutoMapper;
using Shop.Mtg.Dominio;
using Shop.Mtg.Web.ViewModels.Carta;
using Shop.Mtg.Web.ViewModels.Edicao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Mtg.Web.AutoMapper
{
    public class ViewModelToDominioProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<CartaViewModel, Carta>();
            Mapper.CreateMap<EdicaoViewModel, Edicao>();
        }
    }
}