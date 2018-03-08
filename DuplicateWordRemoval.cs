using System;
using System.Linq;

class DuplicateWordRemoval
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence below with no punctution: ");
        string sentence = Console.ReadLine();

        string[] split = sentence.ToLower().Split();

        var filterSentence =
            from word in split
            orderby word
            select word;

        Console.WriteLine("\nNonduplicating words are: ");
        foreach(var word in filterSentence.Distinct())
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }
}
