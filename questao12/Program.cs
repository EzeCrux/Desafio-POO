using System;

class Funcionario
{
    public string Nome;
    public double Salario;

    public Funcionario(string nome, double salario)
    {
        Nome = nome;
        Salario = salario;
    }

    public void AumentarSalario(double percentual)
    {
        Salario += Salario * (percentual / 100);
    }

    public void MostrarDados()
    {
        Console.WriteLine($"Nome: {Nome}, Salário: {Salario:F2}");
    }
}

class Program
{
    static void Main()
    {
        Funcionario f1 = new Funcionario("Ezequiel", 2000);
        f1.MostrarDados();

        f1.AumentarSalario(10);
        f1.MostrarDados();
    }
}
