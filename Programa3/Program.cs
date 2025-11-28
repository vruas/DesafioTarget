using Programa3;
using System.Globalization;

Console.Write("Digite o valor original: ");
decimal valor = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Digite a data de vencimento (dd/MM/yyyy): ");
DateTime vencimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

var resultado = CalculadoraJuros.CalcularJuros(valor, vencimento);

Console.WriteLine("\n===== Resultado do Cálculo =====");
Console.WriteLine($"Valor Original:      R$ {resultado.ValorOriginal:F2}");
Console.WriteLine($"Dias de atraso:      {resultado.DiasAtraso}");
Console.WriteLine($"Juros calculado:     R$ {resultado.JurosCalculado:F2}");
Console.WriteLine($"Valor final a pagar: R$ {resultado.ValorFinal:F2}");
