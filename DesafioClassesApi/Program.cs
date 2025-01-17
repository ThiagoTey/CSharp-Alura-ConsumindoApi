using System.Text.Json;
using DesafioClassesApi.Modelos;
using ScreenSound_4.Modelos;

async Task ExibirFilmes()
{
    using (HttpClient client = new HttpClient())
    {
        try
        {
            string json = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
            var data = JsonSerializer.Deserialize<List<Filme>>(json)!;
            data[0].ExibirDados();
        } catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}


//await ExibirFilmes();

async Task ExibitPaises()
{
    using(HttpClient client = new HttpClient())
    {
        try
        {
            string json = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
            List<Paises> data = JsonSerializer.Deserialize<List<Paises>>(json)!;
            data[0].ExibirDados();
            foreach (Paises pais in data)
            {
                pais.ExibirDados();
            }
        } catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

//await ExibitPaises();

async Task ExibirCarros()
{
    using(HttpClient client = new HttpClient())
    {
        try
        {
            string json = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
            var data = JsonSerializer.Deserialize<List<Carro>>(json)!;
            foreach(Carro carro in data)
            {
                Console.WriteLine(carro.Informacoes);
            }
        } catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

//await ExibirCarros();

async Task Exibirlivros()
{
    using(HttpClient client = new HttpClient())
    {
        try
        {
            string json = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
            var data = JsonSerializer.Deserialize<List<Livro>>(json)!;

            foreach (Livro livro in data)
            {
                livro.ExibirInformacoes();
            }
        } catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

await Exibirlivros();