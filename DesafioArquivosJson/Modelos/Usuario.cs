using System.Text.Json;

namespace DesafioArquivosJson.Modelos;

internal class Usuario
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }

    public Usuario(string nome, int idade, string email)
    {
        Nome = nome;
        Idade = idade;
        Email = email;
    }

    public void GerarArquivoJson()
    {
        var json = JsonSerializer.Serialize(this);

        string nomeDoArquivo = $"Usuario-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"Arquivo Json Criado com suceso em : {Path.GetFullPath(nomeDoArquivo)}");
    }
}
