using System;

class Carro
{
    private double velocidade;

    public Carro()
    {
        velocidade = 0;
    }

    public void Acelerar(double incremento)
    {
        if (incremento < 0)
        {
            Console.WriteLine("Incremento inválido.");
            return;
        }

        velocidade += incremento;
        if (velocidade > 200)
            velocidade = 200;

        Console.WriteLine($"Velocidade atual: {velocidade} km/h");
    }
}

class Program
{
    static void Main()
    {
        Carro carro = new Carro();
        carro.Acelerar(50);
        carro.Acelerar(180);
        carro.Acelerar(-20);
    }
}
