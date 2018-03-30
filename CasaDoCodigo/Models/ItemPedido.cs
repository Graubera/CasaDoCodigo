using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models
{
    public class ItemPedido
    {
        public ItemPedido(int id, Produto produto, int quantidade)
        {
            this.Id = id;
            this.Produto = produto;
            this.Quantidade = quantidade;
            this.PrecoUnitario = produto.Preco;
        }
        public int Id { get; private set; }
        public Produto Produto { get; private set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; private set; }
        public decimal Subtotal { get { return Quantidade * PrecoUnitario; } }


    }
}
