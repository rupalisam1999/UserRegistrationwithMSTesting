using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationWithMSTesting
{
    public class UserRegistration
    {
        const string FIRST_NAME_PATTERN = "^[A-Z]{1}[a-z]{3,}$";
        const string LAST_NAME_PATTERN = "^[A-Z]{1}[a-z]{3,}$";
        const string EMAIL_PATTERN = "^[\\w!#$%&'*+/=?`{|}~^-]+(?:\\.[\\w!#$%&'*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z0-9]{2,6}$";
        const string PHONE_NO_PATTERN = "^[0-9]{2}[ ][0-9]{10}$";
        const string PASSWORD_PATTERN = "^(?=.*[A-Z])(?=.*[@#$%&*!_.-=])(?=.*[0-9])[a-zA-Z0-9].{8,}$";
        private string message;

        public UserRegistration(string message)
        {
            this.message = message;
        }

        public UserRegistration()
        {
        }

        public bool ValidateFirstName(string firrstName)
        {
            var result = Regex.Match(firrstName, FIRST_NAME_PATTERN);
            if (result.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidateLatName(string LastName)
        {
            var result = Regex.Match(LastName, LAST_NAME_PATTERN);
            if (result.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidateEmail(string email)
        {
            var result = Regex.Match(email, EMAIL_PATTERN);
            if (result.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidatePhoneNo(string phoneNo)
        {
            var result = Regex.Match(phoneNo, PHONE_NO_PATTERN);
            if (result.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidatePasswordRule4(string password)
        {
            var result = Regex.Match(password, PASSWORD_PATTERN);
            if (result.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Func<string, bool> isValidFirstName = firstName => Regex.IsMatch(firstName, FIRST_NAME_PATTERN);
        public Func<string, bool> isValidLastName = lastName => Regex.IsMatch(lastName, LAST_NAME_PATTERN);
        public Func<string, bool> isValidEmail = email => Regex.IsMatch(email, EMAIL_PATTERN);
        public Func<string, bool> isValidMobileNumber = mobileFormat => Regex.IsMatch(mobileFormat, PHONE_NO_PATTERN);
        public Func<string, bool> isValidPassword = preDefinedPassword => Regex.IsMatch(preDefinedPassword, PASSWORD_PATTERN);

    }
}
