public class Transaction
{
    public int Id { get; set; }
    public decimal BalanceAfterTransaction { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public required string Type { get; set; }

    public void PrintDetails()
    {
        Console.WriteLine($"Transaction ID: {Id}, Amount: {Amount}, Date: {Date}, Type: {Type}, Balance After Transaction: {BalanceAfterTransaction}");
    }
}