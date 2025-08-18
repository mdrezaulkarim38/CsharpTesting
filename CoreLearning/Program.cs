using CoreLearning.OopPrinciples.Encapsulation;

BankAccount bankAccount = new BankAccount(100);
Console.WriteLine(bankAccount.GetBalance());
bankAccount.Deposit(50);
Console.WriteLine(bankAccount.GetBalance());
bankAccount.Withdraw(25);
Console.WriteLine(bankAccount.GetBalance());
// bankAccount.Withdraw(200);
// Console.WriteLine(bankAccount.GetBalance());

int n = 0;
Console.WriteLine(n++ + ++n);