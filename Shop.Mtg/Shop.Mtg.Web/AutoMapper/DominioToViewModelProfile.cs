using AutoMapper;
using Shop.Mtg.Dominio;
using Shop.Mtg.Web.ViewModels.Carta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Mtg.Web.AutoMapper
{
    public class DominioToViewModelProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Carta, CartaIndexViewModel>()
                .ForMember(c => c.Nome, opt => {
                    opt.MapFrom(src => 
                        string.Format("{0} ({1})", src.Nome, src.Edicao)
                    );
                });
            Mapper.CreateMap<Carta, CartaViewModel>();
        }
    }
}