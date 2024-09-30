
namespace designPattern.OopPrinciples.Encampsulation;

public class GoodBankAccount
{

    private decimal balance;

    //A constructor that is called when the class is initialized
    public GoodBankAccount(decimal balance)
    {
        Deposit(balance);

    }
    //---------------A getter method-----------------

    public decimal GetBalance() { return balance; }


    //---------------A method that is used to deposit the money-----------------
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Amount must be positive and greater than zero");
        }
        this.balance += amount;
    }

    //---------------A method that is used to withdraw the money-----------------
    public void Withdrawal(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Amount must be positive and greater than zero");
        }
        if (amount > balance)
        {
            throw new InvalidOperationException("Insuffient funds");
        }
        this.balance -= amount;
    }
}