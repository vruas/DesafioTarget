using Programa2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Programa2.Infra
{
    public class EstoqueRepository
    {
        private readonly string _caminhoArquivo;
        private EstoqueData _data;

        public EstoqueRepository(string caminhoArquivo)
        {
            _caminhoArquivo = caminhoArquivo;

            if (!File.Exists(caminhoArquivo))
            {
                throw new FileNotFoundException("Arquivo de estoque não encontrado.");
            }

            var json = File.ReadAllText(caminhoArquivo);
            _data = JsonSerializer.Deserialize<EstoqueData>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true})
                ?? throw new Exception("Erro ao deserializar arquivo JSON.");
        }

        public IEnumerable<Produto> ListarProdutos() => _data.Estoque;

        public Produto ObterProdutoPorCodigo(int codigo)
            => _data.Estoque.FirstOrDefault(p => p.CodigoProduto == codigo)
           ?? throw new KeyNotFoundException("Produto não encontrado.");

        public void AtualizarProduto(Produto produto)
        {
            var index = _data.Estoque.FindIndex(p => p.CodigoProduto == produto.CodigoProduto);

            if (index < 0)
            {
                throw new KeyNotFoundException("Produto não encontrado para atualização.");
            }

            _data.Estoque[index] = produto;
            Salvar();
        }

        private void Salvar()
        {
            var json = JsonSerializer.Serialize(_data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_caminhoArquivo, json);
        }
        
    }

    

    public class EstoqueData
    {
        public List<Produto> Estoque { get; set; }
    }
}
