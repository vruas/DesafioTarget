using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Programa1;

public class Venda
{
    [JsonPropertyName("vendedor")]
    public string Vendedor {  get; set; }
    [JsonPropertyName("valor")]
    public double Valor { get; set; }

}
