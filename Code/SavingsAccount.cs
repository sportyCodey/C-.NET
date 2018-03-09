//A class for demonstrating a savings account

public class SavingsAccount
{
    public static decimal AnnualInterestRate { get; set; }

    private decimal savingsBalance;

    public SavingsAccount(decimal savingsBalance)
    {
        SavingsBalance = savingsBalance;
    }

    public decimal SavingsBalance
    {
        get
        {
            return savingsBalance;
        }
        set
        {
            if (value < 0)
                savingsBalance = 0;
            else
                savingsBalance = value;
        }
    }

    public void CalculateInterestRate()
    {
        SavingsBalance += SavingsBalance * (AnnualInterestRate / 12);
    }

    public override string ToString() =>
        $"New Balance: {SavingsBalance:C}.";
}//end class
