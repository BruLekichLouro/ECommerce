using MeuECommerce;
using MeuECommerce.Models;
using MeuECommerce.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2.Repositories
{
    public interface IItemPedidoRepository
    {
        ItemPedido GetItemPedido(int itemPedidoId);
    }
    public class ItemRepository
    {
        public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
        {
            public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
            {

            }

            public ItemPedido GetItemPedido(int itemPedidoId)
            {
                return
                dbSet
                     .Where(ip => ip.Id == itemPedidoId)
                     .SingleOrDefault();
            }
        }
    }
}
