using System;

public class IntegerSet
{
    const int setSize = 50;
    private bool[] set = new bool[setSize];

    public IntegerSet(bool[] testSet = null)
    {
        if (ExceptionCheck(testSet)) //if ExceptionCheck passes, then proceed
            set = testSet;
    }

    private bool ExceptionCheck(bool[] testSet)
    {
        try
        {
            if (testSet.Length > setSize)
                throw new ArgumentOutOfRangeException();
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Array length is too large. " +
                $"Array length: {testSet.Length} needs to be " +
                $"less than {setSize}.");
            return false;
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("This set is null.");
            return false;
        }

        return true;
    }

    private bool ExceptionCheck(int index)
    {
        if (index > setSize || index < 0)
        {
            Console.WriteLine($"Index is invalid. " +
            $"Index: {index} needs to be " +
                $"less than {setSize} and greater than 0.");
            return false;
        }

        return true;
    }

    public bool[] UnionOfSet(bool[] testSet)
    {
        bool[] union = null;

        if (ExceptionCheck(testSet))
        {
            union = new bool[setSize];

            for (int i = 0; i < setSize; i++)
            {
                if (testSet[i] || set[i])
                    union[i] = true;
            }
        }

        return union;
    }

    public bool[] Intersection(bool[] testSet)
    {
        bool[] intersection = null;

        if (ExceptionCheck(testSet))
        {
            intersection = new bool[setSize];

            for (int i = 0; i < setSize; i++)
            {
                if (testSet[i] && set[i])
                    intersection[i] = true;
            }

        }
        return intersection;
    }

    public void InsertElement(int index)
    {
        if (ExceptionCheck(index))
        {
            set[index] = true;
        }
    }

    public void DeleteElement(int index)
    {
        if (ExceptionCheck(index))
        {
            set[index] = false;
        }
    }

    public bool IsEqual(bool[] testSet)
    {
        int count = 0;

        if (ExceptionCheck(testSet))
        {
            for (int i = 0; i < setSize; i++)
            {
                if (set[i] && testSet[i])
                    count++;
               // else
                   // return false; haven't tested this. Might be faster this way
            }
        }

        if (count == setSize) return true;
        return false;
    }

    public override string ToString()
    {
        string output = string.Empty;
        for (int i = 0; i < setSize; i++)
        {
            if (set[i])
                output += (i + 1) + " ";
        }
        if (string.IsNullOrEmpty(output))
            return "---";
        else
        {
            return "The indexes of the set that are not empty:\n " + output;
        }
    }
}//end class
