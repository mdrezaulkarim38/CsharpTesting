namespace CoreLearning.SOLID;
public class BankAccount
{
    public int AccountNumber { get; set; }
    public double Balance { get; set; }
    public List<string> Transactions { get; set; }

    public BankAccount(int accountNumber)
    {
        AccountNumber = accountNumber;
        Transactions = new List<string>();
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Transactions.Add("Deposit " + AccountNumber + ", Balance = "+ Balance);
    }

    public void Withdraw(double amount)
    {
        Balance -= amount;
        Transactions.Add("Withdraw " + AccountNumber + ", Balance = "+ Balance);
    }
}

public class StatementPrinter
{
    public void Print(BankAccount account)
    {
        Console.WriteLine(account.AccountNumber);
        foreach (var transaction in account.Transactions)
        {
            Console.WriteLine(transaction);
        }
    }
}