
namespace designPattern.OopPrinciples.Abstraction;

public class BadSendEmails{

    public void Connect(){
        Console.WriteLine("Connecting to the email server");
    }
    public void Authenticate(){
        Console.WriteLine("Aunthenticating the user to the server");
    }
    public void SendingEmail(){
        Console.WriteLine("Sending the the email to the user");
    }
    public void Disconnect(){
        Console.WriteLine("Deconnecting the server");
    }
}
