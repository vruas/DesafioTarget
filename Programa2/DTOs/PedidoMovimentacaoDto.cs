using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa2.DTOs
{
    public class PedidoMovimentacaoDto
    {
        public int CodigoProduto { get; set; }
        public string Tipo { get; set; } = string.Empty; // Entrada/Saída
        public int Quantidade { get; set; }
    }
}
