using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa2.DTOs
{
    public class ResultadoMovimentacaoDto
    {
        public Guid IdMovimentacao { get; set; }
        public int CodigoProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public string Tipo { get; set; }
        public int QuantidadeMovimentada { get; set; }
        public int EstoqueFinal { get; set; }
    }
}
