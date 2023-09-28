using Newtonsoft.Json;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.Repositories
{
    public class CartasNoelRepository:ICartasRepository
    {
        #region Métodos
        string _arquivojogos = @".\FileJsonData\CartasPapaiNoel.json";

        private List<NoelCartas> ListarCartas()
        {
            if (!System.IO.File.Exists(_arquivojogos))
            {
                return new List<NoelCartas>();
            }
            Directory.CreateDirectory(_arquivojogos.Substring(0, _arquivojogos.LastIndexOf('\\') + 1));
            string Readjson = System.IO.File.ReadAllText(_arquivojogos);
            return JsonConvert.DeserializeObject<List<NoelCartas>>(Readjson);
        }
        private void EscreverCartasNoel(List<NoelCartas> cartas)
        {
            string Readjson = JsonConvert.SerializeObject(cartas);
            System.IO.File.WriteAllText(_arquivojogos, Readjson);
        }
        #endregion

        public void ReceberCartasNoel(NoelCartas cartasNoel)
        {

            List<NoelCartas> cartas = ListarCartas();
            cartas.Add(cartasNoel);
            EscreverCartasNoel(cartas);
        }

        public List<NoelCartas> ListarTodasAsCartasNoel()
        {
            List<NoelCartas> cartaslista = ListarCartas();
            List<NoelCartas> lista = cartaslista;
            return lista;
        }
    }
}
