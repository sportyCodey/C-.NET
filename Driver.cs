using System;

class Driver
{
    static void Main()
    {
        // var one = new Rectangle();

        //one.Width = 1.7;
        //one.Length = 19.8;

        //Console.WriteLine($"Perimeter: {one.Perimeter}, Area: {one.Area}");
        /*
               var saver1 = new SavingsAccount(2000.00M);
               var saver2 = new SavingsAccount(3000.00M);

               SavingsAccount.AnnualInterestRate = 4;

               saver1.CalculateInterestRate();
               saver2.CalculateInterestRate();

               Console.WriteLine(saver1);
               Console.WriteLine(saver2);

               SavingsAccount.AnnualInterestRate = 5;

               saver1.CalculateInterestRate();
               saver2.CalculateInterestRate();

               Console.WriteLine(saver1);
               Console.WriteLine(saver2);
               */
        /*
 bool[] arr = new bool[50];

 Random random = new Random();
 for (int i = 0; i < 50; i++)
 {
     arr[i] = true;
 }
 var mySet = new IntegerSet();
 mySet.DeleteElement(4);
// mySet.InsertElement(10);
 Console.WriteLine(mySet.IsEqual(arr));
 Console.WriteLine(mySet.ToString());

 bool[] newArr = mySet.UnionOfSet(arr);

 for (int i = 0; i< newArr.Length; ++i)
 {
     Console.Write(newArr[i] + " " + i);
 }
 */
        /*
        var myNumber = new RationalNumbers(1, 56);
        var otherNumber = new RationalNumbers(1, 3);

        Console.WriteLine($"{nameof(myNumber)}: {myNumber}");
        Console.WriteLine($"{nameof(otherNumber)}: {otherNumber}");

        Console.WriteLine($"{myNumber} + {otherNumber} = " +
            (myNumber + otherNumber));

        myNumber.Numerator = 79;

        Console.WriteLine($"{myNumber} + {otherNumber} = " +
          (myNumber + otherNumber));

        Console.WriteLine($"{myNumber} - {otherNumber} = " +
          (myNumber - otherNumber));

        Console.WriteLine($"{myNumber} * {otherNumber} = " +
          (myNumber * otherNumber));

        Console.WriteLine($"{myNumber} / {otherNumber} = " +
         (myNumber / otherNumber));

        Console.WriteLine($"{nameof(myNumber)}: " +
            $"{myNumber.floatingPointFormat()}");
        Console.WriteLine($"{nameof(otherNumber)}: " +
            $"{otherNumber.floatingPointFormat()}");
            */

        var myTime = new Time2(23, 45, 23);
        Console.WriteLine(myTime);

        int counter = 0;
        while (counter < 1000)
        {
            myTime.Tick();
            Console.WriteLine(myTime);
            ++counter;
        }

    }//end Main
}//end Driver
