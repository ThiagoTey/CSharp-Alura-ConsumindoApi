using Desafio7.Models;

namespace Desafio7.Filters;

internal class LinqFilter
{
    public static List<int> FilterUniqueNumbers(List<int> list)
    {
        var filterNumbers = list.Distinct().ToList();
        return filterNumbers;
    } 

    public static List<Book> FilterBookAfter2000(List<Book> books)
    {
        var filteredBooks = books.Where(book => ((ushort)book.Year) > 2000).OrderBy(book => book.Title).Distinct().ToList();
        return filteredBooks;
    }
}
