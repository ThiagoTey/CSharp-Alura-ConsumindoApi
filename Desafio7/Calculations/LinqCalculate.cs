using Desafio7.Models;

namespace Desafio7.Calculations;

internal class LinqCalculate
{
    public static double CalculateProductAvaragePrice(List<Product> products)
    {
        var avaragenumber = products.Average(product => product.Price);
        return avaragenumber;
    }

    public static List<int> EvenNumberns(List<int> numbers)
    {
        var evenNumbers = numbers.Where(number => number % 2 == 0).Select(number => number).ToList();
        return evenNumbers;
    }
}
