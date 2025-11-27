using Programa1;
using System.Text.Json;

string json = File.ReadAllText("dados.json");

var dados = JsonSerializer.Deserialize<Vendas>(json);

var comissoes = new Dictionary<string, double>();

foreach (var venda in dados.vendas)
{
    double comissao = 0;

    if (venda.Valor < 100)
    {
        comissao = 0;
    }
    else if (venda.Valor < 500)
    {
        comissao = venda.Valor * 0.01;
    }
    else
    {
        comissao = venda.Valor * 0.05;
    }

    if (!comissoes.ContainsKey(venda.Vendedor))
    {
        comissoes[venda.Vendedor] = 0;
    }

    comissoes[venda.Vendedor] += comissao; 
}


Console.WriteLine("Comissão total por vendedor:\n");
foreach (var item in comissoes)
{
    Console.WriteLine($"{item.Key}: R$ {item.Value:F2}");
}
