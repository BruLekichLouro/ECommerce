using Aula2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aula2.Repositories
{
    public interface IProdutoRepository
    {
        Task SaveProdutos(List<Livro> livros);
        Task <IList<Produto>> GetProdutos();
    }
}