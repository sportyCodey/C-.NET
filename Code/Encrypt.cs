//This class encrypts numbers

class Encrypt: DataManipulation
{
    public Encrypt()
        : base() { }

    public Encrypt(int num)
        : base(num) { }

    public override void ManipulateData()
    {
        int dummyNum = Num;
        for (int i = encryptedData.Length - 1; i >= 0; i--)
        {
            int temp = dummyNum;
            temp = dummyNum % 10;
            temp += 7;
            temp %= 10;

            encryptedData[i] = temp;

            dummyNum /= 10;
        }
        swap(0, 2);
        swap(1, 3);
    }
}//end class
