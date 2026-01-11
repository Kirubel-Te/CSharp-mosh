public class Customer
{
    public int CustomerId { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required List<Account> Accounts { get; set; }

    public void AddAccount(Account account)
    {
        Accounts.Add(account);
    }
    public Account GetAccount(int accountNumber)
    {
        return Accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
    }

    public void Introduce()
    {
        Console.WriteLine($"Customer: {FirstName} {LastName}, ID: {CustomerId}");
    }
}