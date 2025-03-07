using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01_POO
{
    public class Pedido
    {
        public int NumeroPedido;
        public List<Produto> ListaProduto = new List<Produto>();

        public void ListarPedido()
        {
            Console.WriteLine($"""
                Pedido #{this.NumeroPedido}
                Itens:
                """);
            ListarProdutos();
            Console.WriteLine($"Total: {CalcularTotal()}\n");

        }

        public double CalcularTotal()
        {
            double total = 0.0;
            for(int i = 0; i < ListaProduto.Count; i++)
            {
                total += ListaProduto[i].Preco;
            }
            return total;
        }

        public void ListarProdutos()
        {
            foreach (Produto produto in ListaProduto)
            {
                Console.WriteLine($"-{produto.NomeProduto}");
            }
        }
    }
}
