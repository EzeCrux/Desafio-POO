using System;

class Conta
{
    private double saldo;

    public Conta(double saldoInicial)
    {
        saldo = saldoInicial;
    }

    public void Depositar(double valor)
    {
        saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
            Console.WriteLine($"Saque de {valor} realizado. Saldo atual: {saldo}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }

    public void MostrarSaldo()
    {
        Console.WriteLine($"Saldo: {saldo}");
    }
}

class Program
{
    static void Main()
    {
        Conta conta = new Conta(100);
        conta.MostrarSaldo();
        conta.Depositar(50);
        conta.MostrarSaldo();
        conta.Sacar(120);
        conta.Sacar(50);
        conta.MostrarSaldo();
    }
}
