using UserRegistrationProblem;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome To User Validation Program!");
        Validation validation = new Validation();
        validation.ValidateEmail("Shrikant.xyz@bridgelabz.co.in");
        validation.ValidateEmail("om@gmail.com");
        validation.ValidateEmail("sai123@gmail");
        
    }
}