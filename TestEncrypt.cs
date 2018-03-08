class TestEncrypt
{
    static void Main(string[] args)
    {
        Encrypt num1 = new Encrypt(1234);
        num1.ManipulateData();
        num1.PrintData();

        num1.Num = 4577;
        num1.ManipulateData();
        num1.PrintData();

        Encrypt num2 = new Encrypt();
        num2.ManipulateData();
        num2.PrintData();

        Decrypt num3 = new Decrypt(0189);
        num3.ManipulateData();
        num3.PrintData();

        Decrypt num4 = new Decrypt(4412);
        num4.ManipulateData();
        num4.PrintData();

        Decrypt num5 = new Decrypt();
        num5.ManipulateData();
        num5.PrintData();
    }//end main
}//end class
