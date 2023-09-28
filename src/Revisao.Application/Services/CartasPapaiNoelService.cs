using AutoMapper;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Services
{
    public class CartasPapaiNoelService: ICartasPapaiNoelServices
    {
        private readonly ICartasRepository _cartasPapaiNoelRepository;
        private IMapper _mapper;

        public CartasPapaiNoelService(ICartasRepository cartasRepository, IMapper mapper)
        {
            _cartasPapaiNoelRepository = cartasRepository;
            _mapper = mapper;
        }

        public void ReceberCartasNoel(NovaCartaPapaiNoelViewModel novaCartaPapaiNoelViewModel)
        {
            var novaCarta = _mapper.Map<NoelCartas>(novaCartaPapaiNoelViewModel);
            _cartasPapaiNoelRepository.ReceberCartasNoel(novaCarta);
        }

        public IEnumerable<CartasPapaiNoelViewModel> ListarTodasAsCartasNoel()
        {
            return _mapper.Map<IEnumerable<CartasPapaiNoelViewModel>>(_cartasPapaiNoelRepository.ListarTodasAsCartasNoel());
        }
    }
}
