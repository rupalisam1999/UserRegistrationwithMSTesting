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
    }
}
