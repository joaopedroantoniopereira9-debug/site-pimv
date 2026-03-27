public class Usuario
{
    public string Email { get; set; }
    public string Senha { get; set; }

    public Usuario(string email, string senha)
    {
        Email = email;
        Senha = senha;
    }
}