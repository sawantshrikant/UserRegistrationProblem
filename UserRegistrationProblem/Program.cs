using UserRegistrationProblem;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome To User Validation Program!");
        Validation validation = new Validation();
        validation.ValidatePassword("7Eg23_yhuj");
        validation.ValidatePassword("cdf_eert12");
        validation.ValidatePassword("Shrikant@0611");
        
    }
}