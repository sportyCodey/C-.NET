//This program simulates an airline reservation system

using System;

class AirLineResevSystem
{
    static void Main()
    {
        const int seats = 10;
        bool[] planeSeats = new bool[seats];

        int available;

        int seatsLeft = 10;
        while (seatsLeft >= 1)
        {
            available = -1;
            DisplayChoices();
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: available = AssignSeat(firstClass: true, arr: planeSeats); break;
                case 2: available = AssignSeat(firstClass: false, arr: planeSeats); break;
                default: Console.WriteLine("Invalid input."); continue;
            }

            if (choice == 1 && available == -1)
            {
               int breakOrContinue = ClassIsFull(value: ref seatsLeft, firstClass: true, arr: planeSeats);
               if (breakOrContinue == 1)
                   break;
               else
                   continue;
            }

            if (choice == 2 && available == -1)
            {
                int breakOrContinue = ClassIsFull(value: ref seatsLeft, firstClass: false, arr: planeSeats);
                if (breakOrContinue == 1)
                    break;
                else
                    continue;
            }

            if (!planeSeats[available])
            {
                planeSeats[available] = true;
                --seatsLeft;
            }
            else
            {
                Console.WriteLine("That seat is taken. Please choose " + 
                    "another one.");
            }
        }

        Console.WriteLine("There are no more seats available. " +
            "Next flight leaves in 3 hours.");
    }//end main

    static void DisplayChoices()
    {
        Console.WriteLine("Please type 1 for First Class or " +
            "type 2 for Economy");
    }

    static int AssignSeat(bool firstClass, bool[] arr)
    {
        int available = 0;
        if (firstClass)
            available = FindNextAvailableSeat(firstClass: true, arr: arr);
        else
            available = FindNextAvailableSeat(firstClass: false, arr: arr);

        return available;
    }

    static int FindNextAvailableSeat(bool firstClass, bool[] arr)
    {
        int index = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (firstClass)
            {
                if (i < 5)
                {
                    if (!arr[i])
                    {
                        index = i;
                        break;
                    }
                }
            }
            else
            {
                if (i > 4)
                {
                    if (!arr[i])
                    {
                        index = i;
                        break;
                    }
                }
            }
        }
        return index;
    }

    static int ClassIsFull(ref int value, bool firstClass, bool[] arr)
    {
        int breakOrContinue = 0;
        int available = -1;

        if (firstClass)
        {
            Console.WriteLine("The First Class is full. Do you want to " +
                       "be moved to the Economy Class? ");
        }
        else
        {
            Console.WriteLine("The Economy Class is full. Do you want to " +
                       "be moved to the First Class? ");
        }
        string yn = Console.ReadLine();
        if (yn == "Yes" || yn == "y" || yn == "yes" || yn == "Y")
        {
            if (firstClass)
            {
                available = AssignSeat(firstClass: false, arr: arr);
            }
            else
            {
                available = AssignSeat(firstClass: true, arr: arr);
            }
            if (available == -1)
                breakOrContinue = 1;
            else
            {
                arr[available] = true;
                --value;
            }

        }
        else
            breakOrContinue = 1;

        return breakOrContinue;
    }
}//end class
