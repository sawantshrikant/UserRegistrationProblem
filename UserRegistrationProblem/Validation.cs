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
        public static string SECOND_NAME = "^[A-Z]{1}[a-z]{2,}$";
        public static string E_MAIL = "^[0-9A-Za-z]+[.+-_]{0,1}[0-9A-Za-z]+[@][]A-Za-z]+[.][a-z]{2,3}([.][a-z]{2,3}){0,1}$";
        public static string MOBILE_NUMBER = "^[6-9]{1}[0-9]{9}$";
        public static string PASSWORD = "^(?=.*[A-Z])[0-9A-Za-z]{8,}$";
        public void ValidateFirstName(string name)
        {
            if (Regex.IsMatch(name, FIRST_NAME))
                Console.WriteLine("Valid first name");
            else
                Console.WriteLine("Invalid first name");
        }
        public void ValidateSecondName(string name)
        {
            if (Regex.IsMatch(name, SECOND_NAME))
                Console.WriteLine("Valid second name");
            else
                Console.WriteLine("Invalid second name");
        }
        public void ValidateEmail(string eMail)
        {
            if (Regex.IsMatch(eMail, E_MAIL))
                Console.WriteLine("Valid Email");
            else
                Console.WriteLine("Invalid Email");
        }
        public void ValidateMobileNumber(string number)
        {
            if (Regex.IsMatch(number, MOBILE_NUMBER))
                Console.WriteLine("Valid Mobile Number");
            else
                Console.WriteLine("Invalid Mobile Number");
        }
        public void ValidatePassword(string Password)
        {
            if (Regex.IsMatch(Password, PASSWORD))
                Console.WriteLine("Valid Password");
            else
                Console.WriteLine("Invalid Password");
        }

    }
}
