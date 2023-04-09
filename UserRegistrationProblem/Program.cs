using UserRegistrationProblem;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome To User Validation Program!");
        Validation validation = new Validation();
        validation.ValidatePassword("7Eg23yhuj");
        validation.ValidatePassword("123456ABC");
        validation.ValidatePassword("a2345AB");
        
    }
}