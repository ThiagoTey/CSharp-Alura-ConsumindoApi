using System.Text.Json.Serialization;

namespace ScreenSound_4.Modelos;

internal class Paises
{
    [JsonPropertyName("nome")]
    public string? Nome { get; set; }
    [JsonPropertyName("capital")]
    public string? Capital { get; set; }
    [JsonPropertyName("populacao")]
    public int? Populacao { get; set; }
    [JsonPropertyName("continente")]
    public string? Continente { get; set; }
    [JsonPropertyName("idioma")]
    public string? Idioma { get; set; }

    public void ExibirDados()
    {
        Console.WriteLine($"Nome Pais : {Nome} - Capital : {Capital} - Continente : {Continente}");
        Console.WriteLine($"Populacao : {Populacao} - Idioma : {Idioma}");
    }
}
