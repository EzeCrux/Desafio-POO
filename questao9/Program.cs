using System;

class Produto
{
    public string Nome;
    public double Preco;

    public void AplicarDesconto()
    {
        Preco = Preco * 0.9; // reduz 10%
    }
}

class Program
{
    static void Main()
    {
        Produto produto1 = new Produto();
        produto1.Nome = "Camisa";
        produto1.Preco = 100.0;

        Console.WriteLine($"Produto: {produto1.Nome}");
        Console.WriteLine($"Preço antes do desconto: R${produto1.Preco}");

        produto1.AplicarDesconto();

        Console.WriteLine($"Preço depois do desconto: R${produto1.Preco}");
    }
}
