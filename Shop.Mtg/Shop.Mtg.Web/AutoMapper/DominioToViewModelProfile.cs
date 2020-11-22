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
    public class DominioToViewModelProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Carta, CartaIndexViewModel>()
                .ForMember(p => p.Nome, opt =>
                {
                    opt.MapFrom(src =>
                    src.Edicao.Nome
                    );
                });
            Mapper.CreateMap<Carta, CartaViewModel>();

            Mapper.CreateMap<Edicao, EdicaoIndexViewModel>()
                .ForMember(p => p.Nome, opt =>
                {
                    opt.MapFrom(src =>
                    string.Format("{0} {1}", src.Sigla, src.Nome)
                   );
                });
            Mapper.CreateMap<Edicao, EdicaoViewModel>();
        }
    }
}