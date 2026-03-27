public class Atividade
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Tipo { get; set; }
    public string Data { get; set; }

    public Atividade(int id, string nome, string tipo, string data)
    {
        Id = id;
        Nome = nome;
        Tipo = tipo;
        Data = data;
    }
}