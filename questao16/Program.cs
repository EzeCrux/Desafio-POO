using System;

class Usuario
{
    public string Nome { get; set; }
    public string Email { get; set; }

    public Usuario(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }

    public void AlterarEmail(string novoEmail)
    {
        Email = novoEmail;
    }
}

class Program
{
    static void Main()
    {
        Usuario usuario = new Usuario("Ezequiel", "ezequiel@email.com");
        Console.WriteLine($"Nome: {usuario.Nome}, Email: {usuario.Email}");

        usuario.AlterarEmail("novoemail@email.com");
        Console.WriteLine($"Nome: {usuario.Nome}, Email atualizado: {usuario.Email}");
    }
}
