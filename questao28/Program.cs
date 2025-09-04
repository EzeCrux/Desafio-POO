using System;

class Forma
{
    private double area;

    public Forma(double largura, double altura)
    {
        area = largura * altura;
    }

    public double Area
    {
        get { return area; }
    }
}

class Program
{
    static void Main()
    {
        Forma forma = new Forma(5, 10);
        Console.WriteLine($"Área: {forma.Area}");
    }
}
