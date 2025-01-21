
using System.Text.Json;
using DesafioArquivosJson.Modelos;

void Desafio1()
{
    Console.WriteLine("Cadastro de Usuario e criação arquivo json");
    Console.Write("Insira o nome : ");
    string nome = Console.ReadLine()!;
    Console.Write("Insira a idade : ");
    int idade = int.Parse(Console.ReadLine()!);
    Console.Write("Insira o Email : ");
    string email = Console.ReadLine()!;

    Usuario usuario = new(nome, idade, email);
    usuario.GerarArquivoJson();
}

//Desafio1();

void Desafio2()
{
    string caminhoJson = "C:\\Users\\Tey\\source\\repos\\ScreenSound-4\\DesafioArquivosJson\\bin\\Debug\\net8.0\\Usuario-Thaigo.json";
    string jstonString = File.ReadAllText(caminhoJson);
    var usuario = JsonSerializer.Deserialize<Usuario>(jstonString);
    Console.WriteLine($"Nome : {usuario.Nome}");
}

Desafio2();