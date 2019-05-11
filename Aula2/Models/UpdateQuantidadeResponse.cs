using System.Threading.Tasks;
using Aula2.Models.ViewModels;

namespace Aula2.Models
{
    public class UpdateQuantidadeResponse
    {
        private Task<ItemPedido> itemPedidoDB;
        private ItemPedido itemPedidoDB1;

        public UpdateQuantidadeResponse(ItemPedido itemPedidoDB, CarrinhoViewModel carrinhoViewModel)
        {
            this.itemPedidoDB = this.itemPedidoDB;
            CarrinhoViewModel = carrinhoViewModel;
        }

        public ItemPedido ItemPedido { get; }
        public CarrinhoViewModel CarrinhoViewModel { get; }
    }
}
