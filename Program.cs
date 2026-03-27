using System;

class Program
{
    static void Main()
    {
        var sistema = new SistemaEventos();

        Console.WriteLine("=== LOGIN ===");
        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Senha: ");
        string senha = Console.ReadLine();

        if (!sistema.Login(email, senha))
        {
            Console.WriteLine("Login inválido!");
            return;
        }

        Console.WriteLine("Login realizado!");

        while (true)
        {
            Console.WriteLine("\n1 - Cadastrar participante");
            Console.WriteLine("2 - Inscrever");
            Console.WriteLine("3 - Listar inscrições");
            Console.WriteLine("4 - Gerar certificado");
            Console.WriteLine("0 - Sair");

            var op = Console.ReadLine();

            try
            {
                if (op == "1")
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Email: ");
                    string emailP = Console.ReadLine();

                    sistema.CadastrarParticipante(nome, emailP);
                }

                else if (op == "2")
                {
                    Console.Write("ID Participante: ");
                    int p = int.Parse(Console.ReadLine());

                    Console.Write("ID Atividade: ");
                    int a = int.Parse(Console.ReadLine());

                    sistema.Inscrever(p, a);
                }

                else if (op == "3")
                {
                    sistema.ListarInscricoes();
                }

                else if (op == "4")
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    sistema.GerarCertificado(nome);
                }

                else if (op == "0")
                    break;
            }
            catch
            {
                Console.WriteLine("Erro nos dados!");
            }
        }
    }
}