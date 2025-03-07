using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> usuarios = new List<Usuario>();
            List<Produto> produtos = new List<Produto>();
            List<Pedido> pedidos = new List<Pedido>();
            Menu(usuarios, produtos, pedidos);
        }

        static void Menu(List<Usuario> usuarios, List<Produto> produtos, List<Pedido> pedidos)
        {
            int numero = 1;
            int opcao;
            try
            {
                do
                {
                    Console.WriteLine("""

                    ------------------Menu------------------
                    -Escolha uma opção:
                    1- Adicionar um novo produto.  👍
                    2- Criar um novo pedidos.
                    3- Registrar novo usuário.     👍
                    4- Listar Usuários.            👍
                    5- Listar Pedidos.             
                    6- Listar Produtos.            👍
                    7- Buscar Usuário.
                    0- Sair.                       👍

                    """);

                    opcao = int.Parse(Console.ReadLine());
                    Console.WriteLine("----------------------------------------\n");

                    switch (opcao)
                    {
                        case 1:
                            AdicionarProduto(produtos);
                            break;
                        case 2:
                            ListarProdutos(produtos);
                            CriarPedido(pedidos, produtos, usuarios, numero);
                            break;
                        case 3:
                            AdicionarUsuario(usuarios);
                            break;
                        case 4:
                            ListarUsuarios(usuarios);
                            break;
                        case 5:
                            ListarPedidos(pedidos);
                            break;
                        case 6:
                            ListarProdutos(produtos);
                            break;
                        case 7:
                            break;
                        case 0:
                            Console.WriteLine("Finalizando...");
                            break;
                        default:
                            throw new Exception("Opção Inválida");
                    }
                    Console.WriteLine("\nAperte 'Enter' para continuar.");
                    Console.ReadLine();
                    Console.Clear();
                } while (opcao != 0);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nAperte 'Enter' para continuar.");
                Console.ReadLine();
                Console.Clear();
                Menu(usuarios, produtos, pedidos);
            }
            
        }

        static void AdicionarUsuario(List<Usuario> usuarios)
        {
            Console.WriteLine("Digite o nome do usuário");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite quanto dinheiro o usuário possui na conta bancária:");
            double conta = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o CPF do usuário");
            string cpf = Console.ReadLine();

            Usuario usuario = new Usuario(nome, conta, cpf);
            usuarios.Add(usuario);
        }

        static void ListarUsuarios(List<Usuario> usuarios)
        {
            if(usuarios.Count == 0)
            {
                Console.WriteLine("Não há nenhum usuário cadastrado no sistema.");
                return;
            }
                
            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine($"Nome do Usuario: {usuario.NomeUsuario}");
                Console.WriteLine($"Conta Bancária do Usuario: {usuario.ContaBancaria}");
                Console.WriteLine($"CPF do Usuario: {usuario.Cpf}\n");
            }
        }

        static void AdicionarProduto(List<Produto> produtos)
        {
            Console.WriteLine("Digite o nome do produto");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto:");
            double valor = double.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, valor);
            produtos.Add(produto);
        }

        static void ListarProdutos(List<Produto> produtos)
        {
            if (produtos.Count == 0)
            {
                Console.WriteLine("Não há nenhum produto cadastrado no sistema.");
                return;
            }

            foreach (Produto produto in produtos)
            {
                Console.WriteLine($"Nome do Produto: {produto.NomeProduto}");
                Console.WriteLine($"Preço: {produto.Preco}\n");
            }
        }

        static void CriarPedido(List<Pedido> pedidos, List<Produto> produtos, List<Usuario> usuarios, int numero)
        {
            int opcao, i=1;
            List<Produto> listaPedido = new List<Produto>();

            do
            {
                Console.WriteLine($"Digite o nome do {i}º item que deseja adicionar:");
                i++;
                string nomeProduto = Console.ReadLine();
                foreach(Produto produto in produtos)
                {
                    if (produto.NomeProduto.Equals(nomeProduto, StringComparison.OrdinalIgnoreCase))
                        listaPedido.Add(produto);
                }
                Console.WriteLine("Quer adicionar outro item?(1- sim, 0- não)");
                opcao = int.Parse(Console.ReadLine());
            } while (opcao != 0);

            Console.WriteLine("Digite o cpf do comprador.");
            string cpf = Console.ReadLine();

            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Cpf.Equals(cpf))
                {
                    cpf = usuario.NomeUsuario;
                }
            }

            Pedido pedido = new Pedido(numero, listaPedido, cpf);
            pedidos.Add(pedido);
            numero = +1;
        }

        static void ListarPedidos(List<Pedido> pedidos)
        {
            if (pedidos.Count == 0)
            {
                Console.WriteLine("Não há nenhum pedido cadastrado no sistema.");
                return;
            }

            foreach (Pedido pedido in pedidos)
            {
                Console.WriteLine($"Número do pedido: {pedido.NumeroPedido}");
                Console.WriteLine($"Itens: ");
                for(int i = 0;i < pedido.Produtos.Count;i++)
                {
                    Console.WriteLine($"Item {i}- {pedido.Produtos[i].NomeProduto}");
                }
                Console.WriteLine($"Nome do cliente: {pedido.cliente}\n");
            }
        }
    }
}