using System;
using System.Collections.Generic;
using System.Linq;

public class SistemaEventos
{
    public List<Usuario> usuarios = new();
    public List<Participante> participantes = new();
    public List<Atividade> atividades = new();
    public List<Inscricao> inscricoes = new();

    public SistemaEventos()
    {
        usuarios.Add(new Usuario("admin@email.com", "1234"));

        participantes = Persistencia.CarregarParticipantes();

        atividades.Add(new Atividade(1, "Palestra C#", "Palestra", "10/04"));
        atividades.Add(new Atividade(2, "Workshop Web", "Workshop", "11/04"));
    }

    // LOGIN
    public bool Login(string email, string senha)
    {
        return usuarios.Any(u => u.Email == email && u.Senha == senha);
    }

    // CADASTRO
    public void CadastrarParticipante(string nome, string email)
    {
        participantes.Add(new Participante(participantes.Count + 1, nome, email));
        Persistencia.SalvarParticipantes(participantes);
    }

    // INSCRIÇÃO
    public void Inscrever(int pId, int aId)
    {
        var p = participantes.FirstOrDefault(x => x.Id == pId);
        var a = atividades.FirstOrDefault(x => x.Id == aId);

        if (p == null || a == null)
        {
            Console.WriteLine("Erro na inscrição");
            return;
        }

        inscricoes.Add(new Inscricao(p, a));
        Console.WriteLine("Inscrição realizada!");
    }

    // LISTAR
    public void ListarInscricoes()
    {
        foreach (var i in inscricoes)
            Console.WriteLine($"{i.Participante.Nome} -> {i.Atividade.Nome}");
    }

    // CERTIFICADO
    public void GerarCertificado(string nome)
    {
        var cert = new Certificado(nome, "Semana da Tecnologia");
        cert.Emitir();
    }
}