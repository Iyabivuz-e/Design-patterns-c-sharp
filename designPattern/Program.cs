//Encampsulation

using designPattern.OopPrinciples.Encampsulation;

/// <bad use of writting codes without the encampsulation>
// / <Users can chanege the bank balance the way they want it to be>
BadBankAccount bankAccount = new BadBankAccount();
bankAccount.balance = 100;

/// <Good use of writting codes with encampsulation>
/// <Users cannot modify their bank balance>
/// 
GoodBankAccount goodBankAccount = new GoodBankAccount(100);
Console.WriteLine("Initial bank anccount balance: " + goodBankAccount.GetBalance());

goodBankAccount.Deposit(50);
Console.WriteLine("bank account balance after 50USD deposit: " + goodBankAccount.GetBalance());
goodBankAccount.Withdrawal(20);
Console.WriteLine("bank account balance after 200USD withdrawal: " + goodBankAccount.GetBalance());

