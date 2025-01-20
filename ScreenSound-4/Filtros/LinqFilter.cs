using System.Diagnostics;
using System.Linq;
using ScreenSound_4.Modelos;

namespace ScreenSound_4.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($" - {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();

        Console.WriteLine($"Eximindo artistas por genero musical {genero}");

        foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeArtista)
    {
        var musicasDoArista = musicas.Where(musica => musica.Artista!.Equals(nomeArtista)  ).ToList();

        Console.WriteLine(nomeArtista);
        foreach (var musica in musicasDoArista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPeloAno(List<Musica> musicas, int ano)
    {
        var musicasFiltradas = musicas.Where(musica => int.Parse(musica.Ano) == ano ).ToList();
        Console.WriteLine("Lista de Musicas do Ano : " + ano);

        foreach(var musica in musicasFiltradas)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
}
