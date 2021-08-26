using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationReflection
{
    public class UseCases
    {
        public static string firstName = "^[A-Z][a-z]{3,}$";
        public static string lastName = "^[A-Z][a-z]{3,}$";
        public static string emailId = @"^([a-z]{3})+[\.+]([a-z]{3,})+@([a-z]{2})+[\.+]([a-z]{2})+[\.+]([a-z]{2,})$";
        public static string phoneNumber = "([1-9]{2})+[ ][1-9]+([0-9]{9})";
        public static string password = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!*@#$%^&+=]).{8,}$";
        public void FirstName(string userFirstName)
        {
            if (Regex.IsMatch(userFirstName, firstName) == false)
            {
                throw new handlingcustomException(handlingcustomException.ExceptionType.WRONG_INPUT, "Invalid First Name");
            }
        }
        public void LastName(string userLastName)
        {
            if (Regex.IsMatch(userLastName, lastName) == false)
            {
                throw new handlingcustomException(handlingcustomException.ExceptionType.WRONG_INPUT, "Invalid Last Name");
            }
        }
        public void EmailId(string userEmailId)
        {
            if (Regex.IsMatch(userEmailId, emailId) == false)
            {
                throw new handlingcustomException(handlingcustomException.ExceptionType.WRONG_INPUT, "Invalid Email Id");
            }

        }
        public void PhoneNumber(string userPhoneNumber)
        {
            if (Regex.IsMatch(userPhoneNumber, phoneNumber) == false)
            {
                throw new handlingcustomException(handlingcustomException.ExceptionType.WRONG_INPUT, "Invalid Phone Number");
            }
        }
        public void Password1(string userPassword)
        {
            if (Regex.IsMatch(password, userPassword) == false)
            {
                throw new handlingcustomException(handlingcustomException.ExceptionType.WRONG_INPUT, "Invalid Password");
            }
        }
    }
}
