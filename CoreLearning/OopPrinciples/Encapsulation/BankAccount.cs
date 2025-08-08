namespace CoreLearning.OopPrinciples.Encapsulation;

public class BankAccount
{
    private decimal _balance;

    public BankAccount(decimal balance)
    {
        Deposit(balance);
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be greater than zero");
        }
        this._balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdraw amount must be greater than zero");
        }

        if (amount > this._balance)
        {
            throw new InvalidOperationException("Insufficient balance");
        }
        this._balance -= amount;
    }
}