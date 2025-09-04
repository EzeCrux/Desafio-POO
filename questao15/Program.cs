using System;

class Triangulo
{
    public double Lado1;
    public double Lado2;
    public double Lado3;

    public Triangulo(double lado1, double lado2, double lado3)
    {
        Lado1 = lado1;
        Lado2 = lado2;
        Lado3 = lado3;
    }

    public double Perimetro()
    {
        return Lado1 + Lado2 + Lado3;
    }
}

class Program
{
    static void Main()
    {
        Triangulo t1 = new Triangulo(3, 4, 5);
        Console.WriteLine($"Perímetro: {t1.Perimetro()}");
    }
}
