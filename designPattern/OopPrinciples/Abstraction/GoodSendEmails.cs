
namespace designPattern.OopPrinciples.Abstraction;

public class GoodSendEmails{
    public void SendingEmail(){
        Connect();
        Authenticate();
        Console.WriteLine("Sending the the email to the user");
        Disconnect();
    }

    private void Connect(){
        Console.WriteLine("Connecting to the email server");
    }
    private void Authenticate(){
        Console.WriteLine("Aunthenticating the user to the server");
    }
    private void Disconnect(){
        Console.WriteLine("Deconnecting the server");
    }
}
