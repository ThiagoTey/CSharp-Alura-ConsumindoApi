internal class TesteAt4
{
    public void Metodo()
    {
        Console.WriteLine("Atividade 4 ");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        async Task Ativadade1()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
                    Console.WriteLine(resposta);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        //await Ativadade1();

        void Atividade2()
        {
            try
            {
                Console.WriteLine("***Divisao***");
                Console.WriteLine("Insira dois números");
                int num1 = int.Parse(Console.ReadLine()!);
                int num2 = int.Parse(Console.ReadLine()!);
                Console.WriteLine("Resultado da divisão é : " + num1 / num2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ops! Algo deu errado : " + ex.Message);
            }

        }

        //Atividade2();

        void Atividade3()
        // Declarar uma lista de inteiros e tente acessar um elemento em um índice inexistente
        {
            List<int> list = new List<int>()
    {
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10
    };

            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ops! Algo deu errado : " + ex.Message);
            }
        }

        //Atividade3();

        void Atividade4()
        {
            try
            {
                TesteAt4 teste = null;
                teste.Metodo();
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Ops! Algo deu errado : " + ex.Message);
            }
        }

        Atividade4();
    }
}