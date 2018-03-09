//This program separates digits

using System;

class SeparatingDigits
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        int dummyNum = input;

        int count = 0;
        while (dummyNum != 0)
        {
            dummyNum /= 10;
            ++count;
        }

        int index = count;
        int counter = 0;
        while(counter < count)
        {
            int temp = GetDigit(input, index - 1);
            Console.Write(temp + "  ");
            ++counter;
            --index;
        }
        Console.WriteLine();
    }

    static int GetDigit(int input, int index)
    {
        int counter = 0;
        while (counter < index)
        {
            input /= 10;
            ++counter;
        }
        return input % 10;
    }
}
