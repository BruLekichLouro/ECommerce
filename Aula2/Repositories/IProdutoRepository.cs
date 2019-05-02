using Aula2.Models;
using System.Collections.Generic;

namespace Aula2.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> livros);
        IList<Produto> GetProdutos();
    }
}