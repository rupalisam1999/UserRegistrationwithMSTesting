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
        const string EMAIL_PATTERN = "^[a-z]{2,}[.]{1}[a-z]{3,}[@][a-z]{2,}[.]{1}[a-z]{2,}[.]{1}[a-z]{2,}$";
        const string PHONE_NO_PATTERN = "^[1-9]{2}[ *][6-9]{1}[1-9]{9}$";
        const string PASSWORD_PATTERN = "^[A-Z]{1}[a-z]{3,}[#]{1}[1-9]{1,}$";
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

    }
}
