using System.Text.Json;
using ScreenSound_4.Modelos;
using ScreenSound_4.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[1998].ExibirDetalhesDaMusica();
        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
    } catch (Exception ex)
    {
        Console.WriteLine($"Aconteceu algo de errado: {ex.Message}");
    }

}