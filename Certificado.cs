using System;

public class Certificado
{
    public string NomeParticipante { get; set; }
    public string Evento { get; set; }

    public Certificado(string nome, string evento)
    {
        NomeParticipante = nome;
        Evento = evento;
    }

    public void Emitir()
    {
        Console.WriteLine($"Certificado emitido para {NomeParticipante} no evento {Evento}");
    }
}