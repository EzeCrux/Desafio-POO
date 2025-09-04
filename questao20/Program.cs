using System;

class Jogo
{
    public string Nome { get; set; }
    public string Plataforma { get; set; }

    public Jogo(string nome, string plataforma)
    {
        Nome = nome;
        Plataforma = plataforma;
    }

    public void Jogar()
    {
        Console.WriteLine($"Você está jogando {Nome} no {Plataforma}! ECA");
    }
}

class Program
{
    static void Main()
    {
        Jogo jogo = new Jogo("League of Legends", "PC");
        jogo.Jogar();
    }
}
