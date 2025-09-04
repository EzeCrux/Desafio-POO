using System;

class Veiculo
{
    public string Marca;
    public string Modelo;

    public Veiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public void Acelerar()
    {
        Console.WriteLine("Acelerando!");
    }
}

class Program
{
    static void Main()
    {
        Veiculo v1 = new Veiculo("Toyota", "Corolla");
        Console.WriteLine($"Marca: {v1.Marca}, Modelo: {v1.Modelo}");
        v1.Acelerar();
    }
}
