using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa3
{
    public class CalculadoraJuros
    {
        private const double MultaDiaria = 0.025; 

        public static Resultado CalcularJuros(decimal valorOriginal, DateTime dataVencimento)
        {
            DateTime hoje = DateTime.Today;

            if (dataVencimento > hoje)
            {
                return new Resultado(valorOriginal, 0, 0, valorOriginal);
            }

            int diasAtraso = (hoje - dataVencimento).Days;

            decimal juros = valorOriginal * (decimal)MultaDiaria * diasAtraso;

            decimal valorFinal = valorOriginal + juros;

            return new Resultado(valorOriginal, diasAtraso, juros, valorFinal);
        }
    }

    public record Resultado(decimal ValorOriginal, int DiasAtraso, decimal JurosCalculado, decimal ValorFinal);
}
