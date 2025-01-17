
using System.Text.Json;
using PokeApi.Pokemon;

async Task ProcurarPokemon(string nomePokemon)
{
    try
    {
        using HttpClient client = new HttpClient();
        string resposta = await client.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{nomePokemon}");

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true // Ignora diferenças de maiúsculas/minúsculas
        };
        Pokemon data = JsonSerializer.Deserialize<Pokemon>(resposta, options);

        if (data == null)
        {
            Console.WriteLine("Erro: Não foi possível deserializar o JSON.");
            return;
        }

        Console.WriteLine("\nFormas do Pokemom : ");
        foreach (Form form in data.Forms)
        {
            Console.WriteLine(form.Name);
        }

        Console.WriteLine("\nHabilidades Pokemom : ");
        foreach (AbilityWrapper ability in data.Abilities)
        {
            Console.WriteLine(ability.Ability.Name);
        }

        Console.WriteLine("\nDigite alguma coisa para continuar");
        Console.ReadKey();
        Console.Clear();
        await ExibirMenu();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Pokemon não encontrado! :" + ex.Message);

        Console.WriteLine("Digite alguma coisa para continuar");
        Console.ReadKey();
        await ExibirMenu();
    }
}


Console.WriteLine("Bem vindo ao PokeApi!");
async Task ExibirMenu()
{
    Console.Write("\nDigite o nome de um pokemon : ");
    string nomePokemon = Console.ReadLine()!;
    await ProcurarPokemon(nomePokemon);
}

await ExibirMenu();