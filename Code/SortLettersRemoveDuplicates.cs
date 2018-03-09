//This program sorts letters and removes duplicates

using System;
using System.Linq;
using System.Collections.Generic; 

class SortLettersRemoveDuplicates
{
    static void Main()
    {
        List<char> characters = new List<char>();

        Random random = new Random();
        for (int i = 0; i < 30; i++)
        {
            characters.Add((char)random.Next(65, 90));
        }

        var sortListAsc =
            from ch in characters
            orderby ch
            select ch;

        Console.WriteLine("Sorting the list in ascending order: ");
        if (sortListAsc.Any())
        {
            foreach (var ch in sortListAsc)
            {
                Console.Write($"{ch} ");
            }
        }

        var sortListDec =
            from ch in characters
            orderby ch descending
            select ch;

        Console.WriteLine("\n\nSorting the list in descending order: ");
        if (sortListDec.Any())
        {
            foreach(var ch in sortListDec)
            {
                Console.Write($"{ch} ");
            }
        }

        Console.WriteLine("\n\nSorting the list in ascending order with " +
            "no duplicates: ");
        if (sortListAsc.Any())
        {
            foreach (var ch in sortListAsc.Distinct())
            {
                Console.Write($"{ch} ");
            }
        }
        Console.WriteLine("\n");

    }
}
