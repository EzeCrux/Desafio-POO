using System;

class Aluno
{
    private double nota;

    public double Nota
    {
        get { return nota; }
        set
        {
            if (value >= 0 && value <= 10)
                nota = value;
            else
                Console.WriteLine("Nota inválida. Insira um valor entre 0 e 10.");
        }
    }
}

class Program
{
    static void Main()
    {
        Aluno aluno = new Aluno();
        aluno.Nota = 12;
        Console.WriteLine($"Nota: {aluno.Nota}");
        aluno.Nota = 9;
        Console.WriteLine($"Nota: {aluno.Nota}");
    }
}
