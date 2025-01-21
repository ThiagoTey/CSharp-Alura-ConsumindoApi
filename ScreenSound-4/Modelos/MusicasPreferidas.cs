namespace ScreenSound_4.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Musicas favoritas de {Nome}");
        foreach (Musica musica in ListaDeMusicasFavoritas)
        {
            Console.Write($"- {musica.Nome} DE {musica.Artista}");
        }
    }
}
