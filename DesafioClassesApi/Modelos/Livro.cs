﻿using System.Text.Json.Serialization;

namespace DesafioClassesApi.Modelos;

internal class Livro
{
    [JsonPropertyName("titulo")]
    public string Titulo { get; set; }
    [JsonPropertyName("autor")]
    public string Autor { get; set; }
    [JsonPropertyName("ano_publicacao")]
    public int AnoPublicacao { get; set; }
    [JsonPropertyName("genero")]
    public string Genero { get; set; }
    [JsonPropertyName("paginas")]
    public int Paginas { get; set; }
    [JsonPropertyName("editora")]
    public string Editora { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"\nLivro : {Titulo}, autor : {Autor}, Editora : {Editora}");
        Console.WriteLine($"Ano Publicacao : {AnoPublicacao}, Genero : {Genero}, Número de Paginas : {Paginas}");
    }
}
