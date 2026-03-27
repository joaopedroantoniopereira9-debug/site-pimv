public class Inscricao
{
    public Participante Participante { get; set; }
    public Atividade Atividade { get; set; }

    public Inscricao(Participante p, Atividade a)
    {
        Participante = p;
        Atividade = a;
    }
}