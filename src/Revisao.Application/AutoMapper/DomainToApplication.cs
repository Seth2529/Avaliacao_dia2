using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revisao.Domain.Entities;
using Revisao.Application.ViewModels;
namespace Revisao.Application.AutoMapper
{
	public class DomainToApplication : Profile
	{
        public DomainToApplication()
        {
            CreateMap<NoelCartas, CartasPapaiNoelViewModel>();
            CreateMap<NoelCartas, NovaCartaPapaiNoelViewModel>();
        }
    }
}