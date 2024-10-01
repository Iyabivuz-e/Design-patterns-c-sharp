//Encampsulation

// using designPattern.OopPrinciples.Encampsulation;
// using designPattern.OopPrinciples.Abstraction;

// / <Users can chanege the bank balance the way they want it to be>
// BadBankAccount bankAccount = new BadBankAccount();
// bankAccount.balance = 100;

// GoodBankAccount goodBankAccount = new GoodBankAccount(100);
// Console.WriteLine("Initial bank anccount balance: " + goodBankAccount.GetBalance());

// goodBankAccount.Deposit(50);
// Console.WriteLine("bank account balance after 50USD deposit: " + goodBankAccount.GetBalance());
// goodBankAccount.Withdrawal(20);
// Console.WriteLine("bank account balance after 200USD withdrawal: " + goodBankAccount.GetBalance());


//Abstraction

//Abstraction is the process of hidding unneccesary information of the certain software.

// BadSendEmails badSendEmail = new BadSendEmails();

// //Bad ways of sending emails without the abstraction
// //Wewould be following the patterns and showing the unneccessary steps
// badSendEmail.Connect();
// badSendEmail.Authenticate();
// badSendEmail.SendingEmail();
// badSendEmail.Disconnect();

// //A good way of sending emails with the abstraction
// //We would call one class method that will trigger all methods without showing them.

// GoodSendEmails goodSendEmail = new GoodSendEmails();
// goodSendEmail.SendingEmail();


//Inheritance: 

using designPattern.OopPrinciples.Inheritance;
var car  = new Car();

car.Brand = "Banz";
car.Year = 2000;
car.Starting();
car.Stopping();
car.NumberOfDoors = 4;