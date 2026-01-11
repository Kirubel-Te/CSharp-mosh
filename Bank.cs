public class Bank
{
    public  string Name { get; set; }
    public required List<Customer> Customers { get; set; }

    public Bank(string name)
    {
        Name = name;
    }

    public void AddCustomer(Customer customer)
    {
        Customers.Add(customer);
    }

    public Customer GetCustomer(int customerId)
    {
        return Customers.FirstOrDefault(c => c.CustomerId == customerId);
    }

    public void TransferMoney(Account fromAccount, Account toAccount, decimal amount)
    {
        if (fromAccount.Balance >= amount)
        {
            fromAccount.Withdraw(amount);
            toAccount.Deposit(amount);
            Console.WriteLine($"Transferred {amount} from Account {fromAccount.AccountNumber} to Account {toAccount.AccountNumber}");
        }
        else
        {
            Console.WriteLine("Insufficient funds for transfer.");
        }
    }
}