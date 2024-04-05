using DesignPatternMediator.Dominio.Servicos;

namespace DesignPatternMediator.Infra.Servicos
{
    public class ShoppingMediator : IShoppingMediator
    {
        private readonly IServicoNotificacao _servicoNotificacao;
        private readonly IServicoShopping _servicoShopping;
        private readonly IServicoProduto _servicoProduto;

        public ShoppingMediator(
            IServicoNotificacao servicoNotificacao,
            IServicoShopping servicoShopping,
            IServicoProduto servicoProduto)
        {
            _servicoNotificacao = servicoNotificacao;
            _servicoShopping = servicoShopping;
            _servicoProduto = servicoProduto;
        }

        public void Handle(int id)
        {
            var produto = _servicoProduto.ObterPorId(id);
            _servicoShopping.AdicionarCesta(produto);
            _servicoNotificacao.Notificar(produto);
        }
    }
}
