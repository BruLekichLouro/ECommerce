using MeuECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuECommerce.Repositories
{
    interface IPedidoRepository
    {
    }
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(ApplicationContext contexto) : base(contexto)
        {

        }
    }
}
