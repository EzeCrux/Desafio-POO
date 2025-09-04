using System;

class Pessoa
{
    private int _idade;

    public int Idade
    {
        get { return _idade; }
        set { _idade = value; }
    }
}

class Program
{
    static void Main()
    {
        Pessoa pessoa = new Pessoa();
        pessoa.Idade = 17;
        Console.WriteLine($"Idade: {pessoa.Idade}");
    }
}
