using System;
using CoreLearning.SOLID;

namespace CsharpTesting.CoreLearning
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BankAccount johnsAccount = new BankAccount(123456);
            johnsAccount.Deposit(1000);
            johnsAccount.Withdraw(120);
            
            StatementPrinter printer = new StatementPrinter();
            printer.Print(johnsAccount);
            
        }
    }
}

