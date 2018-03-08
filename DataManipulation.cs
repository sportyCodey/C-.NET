abstract class DataManipulation
{
    public int Num { get; set; }
    protected int[] encryptedData;

    public DataManipulation()
    {
        Num = 0;
        encryptedData = new int[4];
    }

    public DataManipulation(int num)
    {
        Num = num;
        encryptedData = new int[4];
    }

    public void PrintData()
    {
        for (int i = 0; i < encryptedData.Length; i++)
        {
            System.Console.Write(encryptedData[i]);
        }
        System.Console.WriteLine();
    }

    public abstract void ManipulateData();

    protected void swap(int v1, int v2)
    {
        int temp = encryptedData[v1];
        encryptedData[v1] = encryptedData[v2];
        encryptedData[v2] = temp;
    }
}//end class
