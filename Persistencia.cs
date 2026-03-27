using System;
using System.IO;
using System.Collections.Generic;

public class Persistencia
{
    public static void SalvarParticipantes(List<Participante> lista)
    {
        using (StreamWriter sw = new StreamWriter("participantes.txt"))
        {
            foreach (var p in lista)
                sw.WriteLine($"{p.Id};{p.Nome};{p.Email}");
        }
    }

    public static List<Participante> CarregarParticipantes()
    {
        var lista = new List<Participante>();

        if (!File.Exists("participantes.txt"))
            return lista;

        var linhas = File.ReadAllLines("participantes.txt");

        foreach (var l in linhas)
        {
            var dados = l.Split(';');
            lista.Add(new Participante(int.Parse(dados[0]), dados[1], dados[2]));
        }

        return lista;
    }
}