using CasaDoCodigo.DAL;
using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.DAO
{
    public class ItemPedidoDAO : IItemPedidoDAO
    {
        private Context _context;

        public ItemPedidoDAO(Context context)
        {
            this._context = context;
        }

        public IList<ItemPedido> GetItensPedido()
        {
            return _context.ItensPedido.ToList();
        }
    }
}
