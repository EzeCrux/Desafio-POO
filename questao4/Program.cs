using System;

class Livro
{
   
    public string Titulo;
    public string Autor;

    public Livro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
    }

    public void ExibirInfo()
    {
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Autor: " + Autor);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Livro meuLivro = new Livro("Pequeno Principe", "Antoine de Saint-Exupéry\r\n");

        meuLivro.ExibirInfo();
    }
}
