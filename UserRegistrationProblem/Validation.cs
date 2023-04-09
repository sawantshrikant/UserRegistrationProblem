using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class Validation
    {
        public static string FIRST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        public void ValidateFirstName(string name)
        {
            if (Regex.IsMatch(name, FIRST_NAME))
                Console.WriteLine("Valid first name");
            else
                Console.WriteLine("Invalid first name");
        }
    }
}
