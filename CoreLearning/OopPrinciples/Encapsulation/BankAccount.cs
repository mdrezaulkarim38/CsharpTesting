namespace CoreLearning.OopPrinciples.Encapsulation;

public class BankAccount
{
    private decimal balance;
    public BankAccount(decimal balance)
    {
        Deposit(balance);
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Deposit Amount must be positive");
        }
        this.balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdraw amount must be positive");
        }
        else if (amount > balance)
        {
            throw new ArgumentException("Insufficient funds");
        }
        this.balance -= amount;
    }

    public decimal GetBalance()
    {
        return this.balance;
    }
}