using System.Collections.Generic;
using CasaDoCodigo.Models;

namespace CasaDoCodigo.DAO
{
    public interface IItemPedidoDAO
    {
        IList<ItemPedido> GetItensPedido();
    }
}