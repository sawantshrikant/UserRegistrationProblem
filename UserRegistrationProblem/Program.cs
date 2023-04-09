using UserRegistrationProblem;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome To User Validation Program!");
        Validation validation = new Validation();
        validation.ValidateFirstName("Shrikant");
        validation.ValidateFirstName("om");
        validation.ValidateFirstName("sai");
        validation.ValidateFirstName("Ram");
    }
}