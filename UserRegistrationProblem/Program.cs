using UserRegistrationProblem;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome To User Validation Program!");
        Validation validation = new Validation();
        validation.ValidateMobileNumber("7743840611");
        validation.ValidateMobileNumber("123456");
        
    }
}