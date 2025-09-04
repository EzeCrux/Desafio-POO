using System;

class Empregado
{
    private double salario;

    public Empregado(double salarioInicial)
    {
        salario = salarioInicial;
    }

    public double CalcularBonus()
    {
        return salario * 0.1;
    }
}

class Program
{
    static void Main()
    {
        Empregado empregado = new Empregado(2000);
        Console.WriteLine($"Bônus: {empregado.CalcularBonus()}");
    }
}
