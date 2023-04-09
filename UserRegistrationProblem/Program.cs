using UserRegistrationProblem;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome To User Validation Program!");
        Validation validation = new Validation();
        validation.ValidateSecondName("Shrikant");
        validation.ValidateSecondName("om");
        validation.ValidateSecondName("sai");
        validation.ValidateSecondName("Ram");
    }
}