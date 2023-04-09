using UserRegistrationProblem;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome To User Validation Program!");
        Validation validation = new Validation();
        string[] email = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc11@abc.net", "abc-100@abc.net", "abc.100@abc.com.au", "abc@" };
        foreach (string emailItem in email)
        {
            validation.ValidateEmail(emailItem);
        }

    }
}