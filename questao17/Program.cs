using System;
using System.Collections.Generic;

class Biblioteca
{
    private List<string> livros;

    public Biblioteca()
    {
        livros = new List<string>();
    }

    public void AdicionarLivro(string titulo)
    {
        livros.Add(titulo);
    }

    public void MostrarLivros()
    {
        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }
    }
}

class Program
{
    static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();
        biblioteca.AdicionarLivro("O Senhor dos Anéis");
        biblioteca.AdicionarLivro("Harry Potter");
        biblioteca.AdicionarLivro("Dom Casmurro");

        biblioteca.MostrarLivros();
    }
}
