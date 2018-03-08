class Decrypt: DataManipulation
{
    public Decrypt()
        : base()
    {
        initialize();
    }

    public Decrypt(int num)
        : base(num)
    {
        initialize();
    }

    public override void ManipulateData()
    {
        swap(2, 0);
        swap(3, 1);

        for (int i = 0; i < encryptedData.Length; i++)
        {
            if (encryptedData[i] >= 7)
                encryptedData[i] -= 7;
            else
                encryptedData[i] += 3;
        }
    }

    private void initialize()
    {
        int dummyNum = Num;
        for (int i = encryptedData.Length - 1; i >= 0; i--)
        {
            int temp = dummyNum;
            temp = dummyNum % 10;

            encryptedData[i] = temp;

            dummyNum /= 10;
        }
    }
}//end class
