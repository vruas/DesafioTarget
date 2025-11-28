using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa2.Domain
{
    public class Movimentacao
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int CodigoProduto { get; set; }
        public string Tipo { get; set;}
        public int Quantidade { get; set; }
        public DateTime Data { get; } = DateTime.Now;

    }
}
