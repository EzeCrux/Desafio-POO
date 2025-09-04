using System;

class Retangulo
{
  
    public double Largura;
    public double Altura;


    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }

    public double Area()
    {
        return Largura * Altura;
    }
}

class Program
{
    static void Main()
    {

        Retangulo ret = new Retangulo(5, 3);

        Console.WriteLine($"Área do retângulo: {ret.Area()}");
    }
}
