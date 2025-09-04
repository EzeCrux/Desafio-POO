using System;

class Ponto
{
    public double X;
    public double Y;

    public double DistanciaOrigem()
    {
        return Math.Sqrt(X * X + Y * Y);
    }
}

class Program
{
    static void Main()
    {
        Ponto ponto1 = new Ponto();
        ponto1.X = 3;
        ponto1.Y = 4;

        Console.WriteLine($"Distância do ponto ({ponto1.X}, {ponto1.Y}) até a origem: {ponto1.DistanciaOrigem()}");
    }
}
