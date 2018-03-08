using System;

class TortoiseHareSimulation
{
    const int lengthOfTrack = 50;
    const int depthOfTrack = 10;

    static string[,] track = new string[depthOfTrack, lengthOfTrack];

    static bool gameOn = true;
    static void Main()
    {
        int harePostion = 0;
        int tortoisePostion = 0;

        initializeTrack();

        Console.WriteLine("Press Enter to start the race!");
        string input = Console.ReadLine();

        Console.WriteLine("ON YOUR MARK, GET SET\n" +
            "BANG!!!!!\nAND THEY'RE OFF!!!!!");

        displayTrack();

        Random random = new Random();
        while (gameOn)
        {
            MoveAnimal(GetRandom(random), ref harePostion, hare: true);
            MoveAnimal(GetRandom(random), ref tortoisePostion,  hare: false);

            Console.WriteLine("\n\n");
           // input = Console.ReadLine();
            displayTrack();
            Console.WriteLine("\n\n");
        }

        if (tortoisePostion >= lengthOfTrack - 1 && harePostion >= lengthOfTrack - 1)
            Console.WriteLine("It's a tie!");
        else if (tortoisePostion >= lengthOfTrack - 1)
            Console.WriteLine("The winner is the tortoise!!");
        else
            Console.WriteLine("The winner is the hare. Yuck.");

        Console.WriteLine();
    }//end main

    static int GetRandom(Random random)
    {
        return random.Next(1, 11);
    }

    static void MoveAnimal(int random, ref int position, bool hare)
    {
        if (hare)
        {
            Console.Write("Hare: ");
        }
        else
            Console.Write("Tortoise: ");
        Console.WriteLine("Random number: " + random);

        switch (random)
        {
            case 1: if (hare) MakeChanges("H Fall Down", "H", 3, ref position, 0); else MakeChanges("Fast plod", "T", 3, ref position, 1); break;
            case 2: if (hare) MakeChanges("H Fall Down", "H", 3, ref position, 0); else MakeChanges("Fast plod", "T", 3, ref position, 1); break;
            case 3: if (hare) MakeChanges("Big slip", "H", 3, ref position, -1); else MakeChanges("Fast plod", "T", 3, ref position, 1); break;
            case 4: if (hare) MakeChanges("Big slip", "H", 3, ref position, -1); else MakeChanges("Fast plod", "T", 3, ref position, 1); break;
            case 5: if (hare) MakeChanges("Small slip", "H", 2, ref position, -1); else MakeChanges("Fast plod", "T", 3, ref position, 1); break;
            case 6: if (hare) MakeChanges("Small slip", "H", 2, ref position, -1); else MakeChanges("Slip", "T", 4, ref position, -1); break;
            case 7: if (hare) MakeChanges("Big hop", "H", 5, ref position, 2); else MakeChanges("Slip", "T", 4, ref position, -1); break;
            case 8: if (hare) MakeChanges("Big hop", "H", 5, ref position, 2); else MakeChanges("T Fall Down", "T", 2, ref position, 0); break;
            case 9: if (hare) MakeChanges("Small hop", "H", 4, ref position, 1); else MakeChanges("T Fall Down", "T", 2, ref position, 0); break;
            case 10: if (hare) MakeChanges("Small hop", "H", 4, ref position, 1); else MakeChanges("T Fall Down", "T", 2, ref position, 0); break; 
            default: Console.WriteLine("Something went wrong (exit status 1)."); System.Environment.Exit(1); break;
        }
    }

    static void MakeChanges(string moveType, string animal, int spaces, ref int position, int direction)
    {
        int temp = position;
        int currentValue = FindAnimal(animal);
        int legalValue = -2;
        legalValue = IsLegal(ref position, spaces, direction, currentValue);

        Console.WriteLine(animal + " legalValue: " + legalValue);
        if (legalValue == 1)
        {
            switch (moveType)
            {
                case "Fast plod": track[currentValue, position] = animal; track[currentValue, temp] = "_"; break;
                case "H Fall Down": track[currentValue + spaces, position] = animal; track[currentValue, temp] = "_"; break;
                case "Big slip": track[currentValue, position] = animal; track[currentValue, temp] = "_"; break;
                case "Small slip": track[currentValue, position] = animal; track[currentValue, temp] = "_"; break;
                case "Slip": track[currentValue, position] = animal; track[currentValue, temp] = "_"; break;
                case "Big hop": track[currentValue - spaces, position] = animal; track[currentValue, temp] = "_"; break;
                case "T Fall Down": track[currentValue + spaces, position] = animal; track[currentValue, temp] = "_"; break;
                case "Small hop": track[currentValue, position] = animal; track[currentValue, temp] = "_"; break;
                default: Console.WriteLine("Something went wrong (exit status 2)."); System.Environment.Exit(2); break;
            }
        }
        else if (legalValue == 10)
        {
            track[currentValue, position - 1] = animal;
            track[currentValue, temp] = "_";
            Winner();
        }

        Console.WriteLine("Position: " + position);
    }

    static int FindAnimal(string animal)
    {
        int index = 0;
        for (int i = 0; i < depthOfTrack; i++)
        {
            for (int j = 0; j < lengthOfTrack; j++)
            {
                if (track[i, j] == animal)
                {
                    index = i;
                    break;
                }
            }
        }

        return index;
    }

    /* direction: 1 = forward, 2 = upward, 0 = downward, -1 = backward */
    static int IsLegal(ref int position, int spaces, int direction, int currentValue)
    {
        int dummy = position;
        if (direction == 1)
        {
            dummy += spaces;
            if (dummy <= lengthOfTrack - 1)
            {
                if (dummy >= lengthOfTrack - 1)
                {
                    position = lengthOfTrack;
                    return 10; //winner
                }
                position += spaces;
                return 1;
            }
        }
        else if (direction == 2)
        {
            if (currentValue - spaces >= 0)
            {
                return 1;
            }
        }
        else if (direction == 0)
        {
            if (currentValue + spaces <= depthOfTrack - 1)
            {
                return 1;
            }
        }
        else if (direction == -1)
        {
            dummy -= spaces;
            if (dummy >= 0)
            {
                position -= spaces;
                return 1;
            }
        }
      
        return 0;
    }

    static void Winner()
    {
        gameOn = false;
    }

    static void displayTrack()
    {
        for (int i = 0; i < depthOfTrack; i++)
        {
            for (int j = 0; j < lengthOfTrack; j++)
            {
                Console.Write(track[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void initializeTrack()
    {
        for (int i = 0; i < depthOfTrack; i++)
        {
            for (int j = 0; j < lengthOfTrack; j++)
            {
                if (i == 5 && j == 0)
                {
                    track[i, j] = "H";
                }
                else if (i == 6 && j == 0)
                {
                    track[i, j] = "T";
                }
                else
                    track[i, j] = "_";
            }
        }
    }
}//end class

