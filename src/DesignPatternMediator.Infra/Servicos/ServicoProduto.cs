using DesignPatternMediator.Dominio.Entidades;
using DesignPatternMediator.Dominio.Servicos;

namespace DesignPatternMediator.Infra.Servicos
{
    public class ServicoProduto : IServicoProduto
    {
        public Produto ObterPorId(int produtoId)
            => new Produto
            {
                ProdutoId = produtoId,
                Nome = "Dell Laptop",
                Preco = 3000
            };
    }
}
