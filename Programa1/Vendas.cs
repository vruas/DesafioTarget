using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Programa1
{
    public class Vendas
    {
        [JsonPropertyName("vendas")]
        public List<Venda> vendas { get; set; }
    }
}
