// Encapsulations

using CoreLearning.OopPrinciples.Encapsulation;

BankAccount _bankAccount = new BankAccount(100);
Console.WriteLine(_bankAccount.GetBalance());
_bankAccount.Deposit(50);
Console.WriteLine(_bankAccount.GetBalance());
_bankAccount.Withdraw(20);
Console.WriteLine(_bankAccount.GetBalance());