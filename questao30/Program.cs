using System;
using System.Collections.Generic;

class Configuracao
{
    private Dictionary<string, string> configuracoes;

    public Configuracao()
    {
        configuracoes = new Dictionary<string, string>();
    }

    public void SetConfiguracao(string chave, string valor)
    {
        configuracoes[chave] = valor;
    }

    public string GetConfiguracao(string chave)
    {
        if (configuracoes.ContainsKey(chave))
            return configuracoes[chave];
        else
            return "Chave não encontrada";
    }
}

class Program
{
    static void Main()
    {
        Configuracao config = new Configuracao();
        config.SetConfiguracao("tema", "escuro");
        config.SetConfiguracao("volume", "80");

        Console.WriteLine(config.GetConfiguracao("tema"));
        Console.WriteLine(config.GetConfiguracao("volume"));
        Console.WriteLine(config.GetConfiguracao("brilho"));
    }
}
