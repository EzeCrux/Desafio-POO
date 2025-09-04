using System;
using System.Collections.Generic;

class Banco
{
    private List<int> contas;

    public Banco()
    {
        contas = new List<int>();
    }

    public void AdicionarConta(int id)
    {
        if (!contas.Contains(id))
            contas.Add(id);
        else
            Console.WriteLine("Conta já existe.");
    }

    public void RemoverConta(int id)
    {
        if (contas.Contains(id))
            contas.Remove(id);
        else
            Console.WriteLine("Conta não encontrada.");
    }

    public void MostrarContas()
    {
        Console.WriteLine("Contas no banco:");
        foreach (var conta in contas)
            Console.WriteLine(conta);
    }
}

class Program
{
    static void Main()
    {
        Banco banco = new Banco();
        banco.AdicionarConta(101);
        banco.AdicionarConta(102);
        banco.AdicionarConta(101); // tenta adicionar repetida
        banco.MostrarContas();

        banco.RemoverConta(102);
        banco.RemoverConta(999); // tenta remover inexistente
        banco.MostrarContas();
    }
}
