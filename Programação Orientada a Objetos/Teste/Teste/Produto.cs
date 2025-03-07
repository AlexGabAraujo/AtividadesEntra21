using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Produto
    {
        public string NomeProduto;
        public double Preco;

        public Produto(string NomeProduto, double Preco)
        {
            this.NomeProduto = NomeProduto;
            this.Preco = Preco;
        }
    }
}
