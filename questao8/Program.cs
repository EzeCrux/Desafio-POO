using System;

class ContaBancaria
{
    public double Saldo = 382;

    public void Depositar(double valor)
    {
        Saldo += valor;
        Console.WriteLine("Depósito de R$" + valor + " realizado com sucesso!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria();

        Console.WriteLine("Saldo inicial: R$" + conta.Saldo);

        conta.Depositar(1932.50);

        Console.WriteLine("Saldo atual: R$" + conta.Saldo);
    }
}
