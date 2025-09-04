using System;

class Circulo
{
    public double Raio;
    public Circulo(double raio)
    {
        Raio = raio;
    }

    public double Area()
    {
        return Math.PI * Raio * Raio;
    }

    public double Perimetro()
    {
        return 2 * Math.PI * Raio;
    }
}

class Program
{
    static void Main(string[] args)
    {

        Circulo meuCirculo = new Circulo(4);

        Console.WriteLine("Raio do círculo: " + meuCirculo.Raio);
        Console.WriteLine("Área do círculo: " + meuCirculo.Area());
        Console.WriteLine("Perímetro do círculo: " + meuCirculo.Perimetro());
    }
}
