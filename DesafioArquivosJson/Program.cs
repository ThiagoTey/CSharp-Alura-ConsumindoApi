
using System.ComponentModel;
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

//Desafio2();

void Desafio3()
{
    List<Usuario> usuarios = new List<Usuario>();
    while(true)
    {
        Console.WriteLine("Digite o nome de usuário ou 'sair' para sair");
        string nome = Console.ReadLine()!;
        if(nome == "sair")
        {
            break;
        }
        Console.WriteLine("Digite a idade");
        int idade = int.Parse(Console.ReadLine()!);
        Console.WriteLine("digite o email");
        string email = Console.ReadLine()!;

        usuarios.Add(new Usuario(nome, idade, email));
    }

    var json = JsonSerializer.Serialize(usuarios);
    string nomeArquivoJson = "Usuarios.json";
    File.WriteAllText(nomeArquivoJson, json);
    Console.WriteLine("Arquivo gerado com sucesso em :" + Path.GetFullPath(nomeArquivoJson));
}

//Desafio3();

void Desafio4()
{
    string caminho = "Usuarios.json";

    if (File.Exists(caminho))
    {
        string jsonString = File.ReadAllText(caminho);
        List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(jsonString);

        foreach (Usuario usuario in usuarios)
        {
            Console.WriteLine($" - {usuario.Nome}");
        }
    } else
    {
        Console.WriteLine("Caminho do arquivo não existe");
    }


}

Desafio4();