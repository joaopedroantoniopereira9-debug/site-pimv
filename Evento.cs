public class Evento
{
    public string Nome { get; set; }
    public string Descricao { get; set; }

    public Evento(string nome, string descricao)
    {
        Nome = nome;
        Descricao = descricao;
    }
}