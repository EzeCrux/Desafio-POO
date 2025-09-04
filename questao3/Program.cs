using System;

class Animal
{
    public string Nome;
    public int Idade;

    public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal meuAnimal = new Animal("Salsichinha", 2);

        Console.WriteLine("Nome do animal: " + meuAnimal.Nome);
        Console.WriteLine("Idade do animal: " + meuAnimal.Idade + " anos");
    }
}
