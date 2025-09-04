using System;

class Carro
{
    public string Cor = "Vermelho";
}

class Program
{
    static void Main(string[] args)
    {
        Carro meuCarro = new Carro();

        Console.WriteLine("A cor do carro é: " + meuCarro.Cor);
    }
}
