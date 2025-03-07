using Teste;

public class UsuarioService
{
    private List<Usuario> usuarios;

    public UsuarioService(List<Usuario> usuarios)
    {
        this.usuarios = usuarios;
    }

    public void AdicionarUsuario(string nome, double conta, string cpf)
    {
        var usuario = new Usuario(nome, conta, cpf);
        usuarios.Add(usuario);
    }

    public void ListarUsuarios()
    {
        if (usuarios.Count == 0)
        {
            Console.WriteLine("Não há nenhum usuário cadastrado no sistema.");
            return;
        }
        Console.WriteLine("----------Lista de Usuários----------\n");
        foreach (var usuario in usuarios)
        {
            Console.WriteLine($"Nome do Usuario: {usuario.NomeUsuario}");
            Console.WriteLine($"Conta Bancária do Usuario: {usuario.ContaBancaria}");
            Console.WriteLine($"CPF do Usuario: {usuario.Cpf}\n");
        }
    }
}