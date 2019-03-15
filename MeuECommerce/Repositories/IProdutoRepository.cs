using System.Collections.Generic;

namespace MeuECommerce.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> livros);
    }
}