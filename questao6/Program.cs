using System;

class Aluno
{
    public string Nome;
    public double Nota;

    public Aluno(string nome, double nota)
    {
        Nome = nome;
        Nota = nota;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno("João", 8.5);
        Aluno aluno2 = new Aluno("Maria", 9.0);

        if (aluno1.Nota > aluno2.Nota)
        {
            Console.WriteLine(aluno1.Nome + " tem a maior nota: " + aluno1.Nota);
        }
        else if (aluno2.Nota > aluno1.Nota)
        {
            Console.WriteLine(aluno2.Nome + " tem a maior nota: " + aluno2.Nota);
        }
        else
        {
            Console.WriteLine("Ambos têm a mesma nota: " + aluno1.Nota);
        }
    }
}
