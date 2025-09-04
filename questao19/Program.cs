using System;
using System.Collections.Generic;

class Agenda
{
    private List<string> contatos;

    public Agenda(List<string> contatosIniciais)
    {
        contatos = contatosIniciais;
    }

    public string BuscarContato(string nome)
    {
        foreach (var contato in contatos)
        {
            if (contato.ToLower() == nome.ToLower())
                return contato;
        }
        return "Contato não encontrado";
    }
}

class Program
{
    static void Main()
    {
        List<string> listaContatos = new List<string> { "Ana", "Bruno", "Carlos" };
        Agenda agenda = new Agenda(listaContatos);

        Console.WriteLine(agenda.BuscarContato("Bruno"));
        Console.WriteLine(agenda.BuscarContato("Mariana"));
    }
}
