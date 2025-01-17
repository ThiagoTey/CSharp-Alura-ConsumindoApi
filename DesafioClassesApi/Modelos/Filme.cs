using System.Text.Json.Serialization;

namespace DesafioClassesApi.Modelos;

internal class Filme
{
    public string Id { get; set; }
    public string? Rank { get; set; }
    [JsonPropertyName("title")]
    public string? Titulo { get; set; }
    [JsonPropertyName("fullTitle")]
    public string? TituloInteiro { get; set; }
    [JsonPropertyName("year")]
    public string Ano { get; set; }
    [JsonPropertyName("crew")]
    public string? Equipe { get; set; }
    [JsonPropertyName("imDbRating")]
    public string NotaIMDB { get; set; }

    public void ExibirDados()
    {
        Console.WriteLine($"Ranking : {Rank}");
        Console.WriteLine($"Titulo FIlme : {Titulo} - Ano {Ano}");
        Console.WriteLine($"Equipe : {Equipe}");
        Console.WriteLine($"Nota IMDB {NotaIMDB}");
    }
}
