using Programa2.Domain;
using Programa2.DTOs;
using Programa2.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa2.Service
{
    public class MovimentacaoService
    {
        private readonly EstoqueRepository _repository;

        public MovimentacaoService(EstoqueRepository repository)
        {
            _repository = repository;
        }

        public ResultadoMovimentacaoDto RegistrarMovimentacao(PedidoMovimentacaoDto request)
        {
            if (request.Quantidade <= 0)
            {
                throw new ArgumentException("Quantidade deve ser maior que zero.");

            }

            var produto = _repository.ObterProdutoPorCodigo(request.CodigoProduto);

            if (request.Tipo.Equals("Saída", StringComparison.OrdinalIgnoreCase))
            {
                if (produto.Estoque < request.Quantidade) 
                {
                    throw new InvalidOperationException("Estoque insuficiente para saída.");
                }

                produto.Estoque -= request.Quantidade;
            }
            else if (request.Tipo.Equals("Entrada", StringComparison.OrdinalIgnoreCase))
            {
                produto.Estoque += request.Quantidade;
            }
            else
            {
                throw new ArgumentException("Tipo inválido. Use 'Entrada' ou 'Saída'.");
            }

            _repository.AtualizarProduto(produto);

            var mov = new Movimentacao
            {
                CodigoProduto = produto.CodigoProduto,
                Tipo = request.Tipo,
                Quantidade = request.Quantidade
            };

            return new ResultadoMovimentacaoDto
            {
                IdMovimentacao = mov.Id,
                CodigoProduto = produto.CodigoProduto,
                DescricaoProduto = produto.DescricaoProduto,
                Tipo = request.Tipo,
                QuantidadeMovimentada = request.Quantidade,
                EstoqueFinal = produto.Estoque
            };
        }
    }
}
