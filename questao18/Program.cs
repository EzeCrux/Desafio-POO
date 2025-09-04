using System;

class Calculadora
{
    public Calculadora() { }

    public double Somar(double a, double b)
    {
        return a + b;
    }

    public double Subtrair(double a, double b)
    {
        return a - b;
    }

    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    public double Dividir(double a, double b)
    {
        return a / b;
    }
}

class Program
{
    static void Main()
    {
        Calculadora calc = new Calculadora();

        Console.WriteLine(calc.Somar(10, 5));
        Console.WriteLine(calc.Subtrair(10, 5));
        Console.WriteLine(calc.Multiplicar(10, 5));
        Console.WriteLine(calc.Dividir(10, 5));
    }
}
