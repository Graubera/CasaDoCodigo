using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.ViewModel
{
    public class CarrinhoViewModel
    {
        public CarrinhoViewModel(List<ItemPedido> itens)
        {
            this.Itens = itens;
        }

        public List<ItemPedido> Itens { get; private set; }
        public decimal ValorTotal
        {
            get
            {
                return Itens.Sum(i => i.Subtotal);
            }
        }
    }
}
