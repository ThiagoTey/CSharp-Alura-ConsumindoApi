using System.Text.Json;
using ScreenSound_4.Modelos;
using ScreenSound_4.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[1998].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Eminem");
        //LinqFilter.FiltrarMusicasPeloAno(musicas, 2002);

        //var musicasPreferidas = new MusicasPreferidas("Tey");
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[31]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[489]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[7]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[1467]);

        //musicasPreferidas.ExibirMusicasFavoritas();

        var musicasPreferidasJorge = new MusicasPreferidas("Jorge");
        musicasPreferidasJorge.AdicionarMusicasFavoritas(musicas[4]);
        musicasPreferidasJorge.AdicionarMusicasFavoritas(musicas[817]);
        musicasPreferidasJorge.AdicionarMusicasFavoritas(musicas[231]);
        musicasPreferidasJorge.AdicionarMusicasFavoritas(musicas[726]);
        musicasPreferidasJorge.AdicionarMusicasFavoritas(musicas[9]);

        musicasPreferidasJorge.ExibirMusicasFavoritas();
        musicasPreferidasJorge.GerarArquivoJson();

    } catch (Exception ex)
    {
        Console.WriteLine($"Aconteceu algo de errado: {ex.Message}");
    }

}