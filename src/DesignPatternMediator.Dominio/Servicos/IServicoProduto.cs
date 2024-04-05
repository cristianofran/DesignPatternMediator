using DesignPatternMediator.Dominio.Entidades;

namespace DesignPatternMediator.Dominio.Servicos
{
    public interface IServicoProduto
    {
        Produto ObterPorId(int produtoId);
    }
}
