using CasaDoCodigo.DAL;
using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.DAO
{
    public class ProdutoDAO : IProdutoDAO
    {
        private Context _context;

        public ProdutoDAO(Context context)
        {
            this._context = context;
        }        

        public IList<Produto> GetProdutos()
        {
            return _context.Produtos.ToList();
        }
    }
}
