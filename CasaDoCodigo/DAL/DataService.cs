using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.DAL
{
    public class DataService : IDataService
    {
        private readonly Context _context;
        public DataService(Context context)
        {
            // Vamos armazenar esse context dentro de um campo somente leitura
            this._context = context;
        }

        public void InicializaDB()
        {
            this._context.Database.EnsureCreated();
            if (this._context.Produtos.Count() == 0)
            {
                List<Produto> produtos = new List<Produto>
                    {
                         new Produto("Sleep not Found", 59.90m),
                         new Produto("May the code be with you", 59.90m),
                         new Produto("Rollback", 59.90m),
                         new Produto("REST", 69.90m),
                         new Produto("Design Patterns com Java", 69.90m),
                         new Produto("Vire o jogo com Spring Framework", 69.90m),
                         new Produto("Test-Driven Development", 69.90m),
                         new Produto("iOS: Programe para iPhone e iPad", 69.90m),
                         new Produto("Desenvolvimento de Jogos para Android", 69.90m)
                    };

                foreach (var produto in produtos)
                {
                    this._context.Produtos
                        .Add(produto);

                    this._context.ItensPedido
                        .Add(new ItemPedido(produto, 1));
                }
                this._context.SaveChanges();
            }

        }
    }
}
