public class CurrentAccount : Account
{
    private const decimal OverdraftLimit = 1000m;

    public override void Withdraw(decimal amount)
    {
        if (amount <= balance + OverdraftLimit)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Withdrawal denied. Exceeds overdraft limit.");
        }
    }
    public override void Deposit(decimal amount)
    {
        base.Deposit(amount);
    }
}