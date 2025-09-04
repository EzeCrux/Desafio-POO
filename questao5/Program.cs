using System;

class Quadrado
{
    public double Lado;

    public Quadrado(double lado)
    {
        Lado = lado;
    }

    public double Area()
    {
        return Lado * Lado;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Quadrado meuQuadrado = new Quadrado(5);

        Console.WriteLine("Lado do quadrado: " + meuQuadrado.Lado);
        Console.WriteLine("Área do quadrado: " + meuQuadrado.Area());
    }
}
