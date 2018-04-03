using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaDoCodigo.DAL;
using CasaDoCodigo.DAO;
using CasaDoCodigo.Models;
using CasaDoCodigo.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
        private IProdutoDAO _produtoDAO;
        private IItemPedidoDAO _itemPedidoDAO;
        public PedidoController(IProdutoDAO produtoDAO, IItemPedidoDAO itemPedidoDAO)
        {
            this._produtoDAO = produtoDAO;
            this._itemPedidoDAO = itemPedidoDAO;
        }
        public IActionResult Carrossel()
        {
            IList<Produto> produtos = _produtoDAO.GetProdutos();
            return View(produtos);
        }

        public IActionResult Carrinho()
        {
            CarrinhoViewModel viewModel = GetCarrinhoViewModel();
            return View(viewModel);
        }

        public IActionResult Resumo()
        {
            CarrinhoViewModel viewModel = GetCarrinhoViewModel();
            return View(viewModel);
        }

        private CarrinhoViewModel GetCarrinhoViewModel()
        {
            IList<Produto> produtos = _produtoDAO.GetProdutos();
            IList<ItemPedido> itensCarrinho = _itemPedidoDAO.GetItensPedido();
            CarrinhoViewModel viewModel = new CarrinhoViewModel(itensCarrinho);
            return viewModel;
        }
    }
}