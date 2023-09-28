using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Entities
{
    public class NoelCartas
    {
        #region Construtores
        public NoelCartas(string nomeCrianca,string rua, string numero, string bairro, string cidade, string estado, int idadecrianca, string textocarta)
        {
            NomeCrianca = nomeCrianca;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            IdadeCriancaEmAnos = idadecrianca;
            TextoCartaCrianca = textocarta;
        }
        #endregion

        #region Propriedades
        public string NomeCrianca { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int IdadeCriancaEmAnos { get; set; }
        public string TextoCartaCrianca { get; set; }
        #endregion
    }
}
