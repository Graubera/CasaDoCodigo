using System.Collections.Generic;
using CasaDoCodigo.Models;

namespace CasaDoCodigo.DAO
{
    public interface IProdutoDAO
    {
        IList<Produto> GetProdutos();
    }
}