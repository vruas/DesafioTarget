using Programa2.DTOs;
using Programa2.Infra;
using Programa2.Service;
using System.Linq.Expressions;

var repo = new EstoqueRepository("estoque.json");
var service = new MovimentacaoService(repo);

while (true)
{
    Console.WriteLine("\n=== Sistema de Movimentação de Estoque ===");
    Console.WriteLine("1 - Movimentar Produto");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha: ");

    if (Console.ReadLine() == "0") break;

	try
	{
        Console.Write("Código do produto: ");
		int codigo = int.Parse(Console.ReadLine());

        Console.Write("Tipo (Entrada/Saída): ");
		string tipo = Console.ReadLine();

        Console.Write("Quantidade: ");
		int quantidade = int.Parse(Console.ReadLine());

		var request = new PedidoMovimentacaoDto
		{
			CodigoProduto = codigo,
			Tipo = tipo,
			Quantidade = quantidade
		};

		var result = service.RegistrarMovimentacao(request);

        Console.WriteLine("\nMovimentação registrada com sucesso!");
        Console.WriteLine($"ID: {result.IdMovimentacao}");
        Console.WriteLine($"Produto: {result.DescricaoProduto}");
        Console.WriteLine($"Tipo: {result.Tipo}");
        Console.WriteLine($"Quantidade: {result.QuantidadeMovimentada}");
        Console.WriteLine($"Estoque Final: {result.EstoqueFinal}");
    }
	catch (Exception)
	{

		throw;
	}
}
