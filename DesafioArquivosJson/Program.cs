
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

Desafio1();