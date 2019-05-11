using System.Threading.Tasks;
using Aula2.Models.ViewModels;

namespace Aula2.Models
{
    public class UpdateQuantidadeResponse
    {
        private Task<ItemPedido> itemPedidoDB;


        public UpdateQuantidadeResponse(Task<ItemPedido> itemPedidoDB, CarrinhoViewModel carrinhoViewModel)
        {
            this.itemPedidoDB = itemPedidoDB;
            CarrinhoViewModel = carrinhoViewModel;
        }

        public ItemPedido ItemPedido { get; }
        public CarrinhoViewModel CarrinhoViewModel { get; }
    }
}
