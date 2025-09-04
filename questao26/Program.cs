using System;

class Usuario
{
    private string senha;

    public Usuario(string senhaInicial)
    {
        senha = senhaInicial;
    }

    public bool Autenticar(string senhaInformada)
    {
        return senhaInformada == senha;
    }
}

class Program
{
    static void Main()
    {
        Usuario usuario = new Usuario("1234");

        Console.WriteLine(usuario.Autenticar("1234")); // true
        Console.WriteLine(usuario.Autenticar("0000")); // false
    }
}
