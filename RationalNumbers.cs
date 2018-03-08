using System;

public class RationalNumbers
{
    private int numerator;
    private int denominator;

    public RationalNumbers(int numerator = 0, int denominator = 0)
    {
        Reduce(numerator, denominator);
    }

    public int Numerator
    {
        get
        {
            return numerator;
        }
        set
        {
            numerator = value;
        }
    }

    public int Denominator
    {
        get
        {
            return denominator;
        }
        set
        {
            denominator = value;
        }
    }

    private void Reduce(int n, int d)
    {
        int max = Math.Max(n, d);

        int gcd = 0;
        int temp1 = -1;
        int temp2 = -2;
        for (int i = 0; i <= max; i++)
        {
            temp1 = -1;
            temp2 = -2;
            if ((n / (double)i) % 1 == 0 && i <= n)
            {
                temp1 = i;
            }
            if ((d / (double)i) % 1 == 0 && i <= d)
            {
                temp2 = i;
            }
            if (temp1 == temp2)
            {
                gcd = i;
            }
        }

        Numerator = n / gcd;
        Denominator = d / gcd;
    }

    public static RationalNumbers operator+(RationalNumbers a, RationalNumbers b)
    {
        RationalNumbers cloneA = new RationalNumbers(a.Numerator, a.Denominator);
        RationalNumbers cloneB = new RationalNumbers(b.Numerator, b.Denominator);

        if (cloneA.Denominator >= cloneB.Denominator)
        {
            AddOrSubtract(cloneA.Denominator, cloneB.Denominator, cloneA, cloneB);
        }
        else 
        {
            AddOrSubtract(cloneB.Denominator, cloneA.Denominator, cloneB, cloneA);
        }

        return new RationalNumbers(cloneA.Numerator + cloneB.Numerator,
            cloneA.Denominator);
    }

    private static void AddOrSubtract(int largerNum, int smallerNum,
        RationalNumbers largerObj, RationalNumbers smallerObj)
    {
        int aTemp = largerObj.Denominator;
        int bTemp = smallerObj.Denominator;
        if (smallerNum % largerNum == 0)
        {
            smallerObj.Denominator = largerObj.Denominator;
        }
        else
        {
            smallerObj.Denominator *= largerObj.Denominator;
            largerObj.Denominator *= bTemp;
        }

        largerObj.Numerator *= largerObj.Denominator / aTemp;
        smallerObj.Numerator *= smallerObj.Denominator / bTemp;
    }

    public static RationalNumbers operator-(RationalNumbers a, RationalNumbers b)
    {
        RationalNumbers cloneA = new RationalNumbers(a.Numerator, a.Denominator);
        RationalNumbers cloneB = new RationalNumbers(b.Numerator, b.Denominator);

        if (cloneA.Denominator >= cloneB.Denominator)
        {
            AddOrSubtract(cloneA.Denominator, cloneB.Denominator, cloneA, cloneB);
        }
        else
        {
            AddOrSubtract(cloneB.Denominator, cloneA.Denominator, cloneB, cloneA);
        }

        return new RationalNumbers(cloneA.Numerator - cloneB.Numerator,
            cloneA.Denominator);
    }

    public static RationalNumbers operator*(RationalNumbers a, RationalNumbers b)
    {
        return new RationalNumbers(a.Numerator * b.Numerator,
            a.Denominator * b.Denominator);
    }

    public static RationalNumbers operator/(RationalNumbers a, RationalNumbers b)
    {
        return new RationalNumbers(a.Numerator * b.Denominator,
            a.Denominator * b.Numerator);
    }

    public override string ToString() =>
        $"{Numerator}/{Denominator}";

    public string floatingPointFormat() =>
        $"{Numerator:F2}/{Denominator:F2}";
}//end class
