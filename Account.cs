using System.Security.Principal;

public class Account
{
    protected decimal balance;
    public int AccountNumber { get; set; }
    public required string AccountHolder { get; set; }
    public required string AccountType { get; set; }
    public decimal Balance => balance;
    public required List<Transaction> Transactions{get; set;}

    public virtual void Deposit(decimal amount)
    {
        balance += amount;
        Transactions.Add(new Transaction
        {
            Amount = amount,
            BalanceAfterTransaction = balance,
            Date = DateTime.Now,
            Type = "Deposit"
        });
    }
    public virtual void Withdraw(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
        Transactions.Add(new Transaction
        {
            Amount = amount,
            BalanceAfterTransaction = balance,
            Date = DateTime.Now,
            Type = "Withdrawal"
        });
    }
    public void showTransactions()
    {
        foreach (var transaction in Transactions)
        {
            transaction.PrintDetails();
        }
    }

    public void PrintAccountInfo()
    {
        Console.WriteLine($"Account Number: {AccountNumber}, Account Holder: {AccountHolder}, Balance: {Balance}");
    }
}