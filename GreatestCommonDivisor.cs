using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        int num1 = 0;
        while (num1 != -1)
        {
            num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int max = Math.Max(num1, num2);

            Console.WriteLine(Gcd(num1, num2, max));
        }
    }

    static int Gcd(int num1, int num2, int max)
    {
        int gcd = 0;
        int temp1 = -1;
        int temp2 = -2;
        for (int i = 1; i <= max; i++)
        {
            temp1 = -1;
            temp2 = -2;
            if ((num1 / (double)i) % 1 == 0 && i <= num1)
            {
                temp1 = i;
            }
            if ((num2 / (double)i) % 1 == 0 && i <= num2)
            {
                temp2 = i;
            }
            if (temp1 == temp2)
            {
                gcd = i;
            }
        }
        return gcd;
    }
}
