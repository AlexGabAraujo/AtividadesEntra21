using Teste;

public class PedidoService
{
    private List<Pedido> pedidos;
    private List<Produto> produtos;
    private List<Usuario> usuarios;

    public PedidoService(List<Pedido> pedidos, List<Produto> produtos, List<Usuario> usuarios)
    {
        this.pedidos = pedidos;
        this.produtos = produtos;
        this.usuarios = usuarios;
    }

    public void CriarPedido(int numeroPedido)
    {
        int opcao, i = 1;
        List<Produto> listaPedido = new List<Produto>();

        do
        {
            Console.WriteLine($"Digite o nome do {i}º item que deseja adicionar:");
            i++;
            string nomeProduto = Console.ReadLine();
            foreach (var produto in produtos)
            {
                if (produto.NomeProduto.Equals(nomeProduto, StringComparison.OrdinalIgnoreCase))
                    listaPedido.Add(produto);
            }
            Console.WriteLine("Quer adicionar outro item?(1- sim, 0- não)");
            opcao = int.Parse(Console.ReadLine());
        } while (opcao != 0);

        Console.WriteLine("Digite o cpf do comprador.");
        string cpf = Console.ReadLine();

        var cliente = usuarios.FirstOrDefault(u => u.Cpf.Equals(cpf));
        if (cliente == null)
        {
            Console.WriteLine("Usuário não encontrado.");
            return;
        }

        var pedido = new Pedido(numeroPedido, listaPedido, cliente.NomeUsuario);
        pedidos.Add(pedido);
    }

    public void ListarPedidos()
    {
        if (pedidos.Count == 0)
        {
            Console.WriteLine("Não há nenhum pedido cadastrado no sistema.");
            return;
        }

        Console.WriteLine("----------Lista de Pedidos----------\n");
        foreach (var pedido in pedidos)
        {
            Console.WriteLine($"Número do pedido: {pedido.NumeroPedido}");
            Console.WriteLine($"Itens: ");
            for (int i = 0; i < pedido.Produtos.Count; i++)
            {
                Console.WriteLine($"Item {i}- {pedido.Produtos[i].NomeProduto}");
            }
            Console.WriteLine($"Nome do cliente: {pedido.cliente}\n");
        }
    }
}