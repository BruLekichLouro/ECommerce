using MeuECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuECommerce.Repositories
{
    public interface IItemPedidoRepository
    {
        void UpdateQuantidade(ItemPedido itemPedido);
        
    }
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {

        }

        public void UpdateQuantidade(ItemPedido itemPedido)
        {
            throw new NotImplementedException();
        }
    }
}
