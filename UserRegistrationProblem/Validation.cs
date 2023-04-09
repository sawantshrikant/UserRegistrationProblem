using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class Validation
    {
        public static string FIRST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        public static string LAST_NAME = "^[A-Z]{1}[a-z]{2,}$";
        public static string E_MAIL = "^[0-9A-Za-z]+[.+-_]{0,1}[0-9A-Za-z]+[@][A-Za-z]+[.][a-z]{2,3}([.][a-z]{2,3}){0,1}$";
        public static string MOBILE_NUMBER = "^[6-9]{1}[0-9]{9}$";
        public static string PASSWORD = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[@#$%^&+=]).{8,}$";

        public bool ValidateFirstName(string name)
        {
            return Regex.IsMatch(name, FIRST_NAME);
        }

        public bool ValidateLastName(string name)
        {
            return Regex.IsMatch(name, LAST_NAME);
        }

        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, E_MAIL);
        }

        public bool ValidateMobileNumber(string number)
        {
            return Regex.IsMatch(number, MOBILE_NUMBER);
        }

        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, PASSWORD);
        }
    }
}
