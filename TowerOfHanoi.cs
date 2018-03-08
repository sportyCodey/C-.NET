using System;

class TowerOfHanoi
{
    private static int storgePeg;

    static void Main()
    {
        Console.Write("How many disks? ");
        int numOfDisks = int.Parse(Console.ReadLine());
        Tower(numOfDisks, 1, 2, 3);

    }

    static void Tower(int numOfDisks, int initialPeg, int movePeg, int storagePeg)
    {
        if (numOfDisks == 1)
        {
            Console.WriteLine($"{initialPeg} --> {movePeg}");
        }
        else
        {
            Tower(numOfDisks - 1, initialPeg, storagePeg, movePeg);
            Console.WriteLine($"{initialPeg} --> {movePeg}");

            Tower(numOfDisks - 1, storagePeg, movePeg, initialPeg);
        }
    }
}
