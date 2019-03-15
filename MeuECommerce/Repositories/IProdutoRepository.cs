using MeuECommerce.Models;
using System.Collections.Generic;

namespace MeuECommerce.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> livros);
        IList<Produto> GetProdutos();
    }
}