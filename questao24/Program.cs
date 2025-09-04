using System;

class Produto
{
    private double preco;

    public Produto(double precoInicial)
    {
        if (precoInicial < 0)
            throw new ArgumentException("Preço inicial não pode ser negativo.");
        preco = precoInicial;
    }

    public void AplicarDesconto(double valor)
    {
        if (valor < 0)
        {
            Console.WriteLine("Desconto inválido.");
            return;
        }

        if (preco - valor < 0)
            preco = 0;
        else
            preco -= valor;
    }

    public void MostrarPreco()
    {
        Console.WriteLine($"Preço atual: {preco}");
    }
}

class Program
{
    static void Main()
    {
        Produto produto = new Produto(100);
        produto.MostrarPreco();
        produto.AplicarDesconto(30);
        produto.MostrarPreco();
        produto.AplicarDesconto(80);
        produto.MostrarPreco();
        produto.AplicarDesconto(-10);
    }
}
