using System;

class RandomNumberPractice
{
    static Random random = new Random();

    static void Main()
    {
        ;

        int n = 0;
        n = GetRandom(n);

        int counter = 0;
        while (counter < 100)
        {
            Console.WriteLine(n);
            n = GetRandom(n);
            ++counter;
        }
    }
    /* a
    static int GetRandom(int n)
    {
        return 2 + 2 * random.Next(5);
    }
    */

    /* b
    static int GetRandom(int n)
    {
        return 1 + (2 + 2 * random.Next(5));
    }
    */

    /* c */
    static int GetRandom(int n)
    {
        return 2 * (1 + (2 + 2 * random.Next(5)));
    }
}
