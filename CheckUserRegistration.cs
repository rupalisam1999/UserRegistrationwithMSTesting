using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationWithMSTesting
{
    public class CheckUserRegistration
    {
        private string message;

        public CheckUserRegistration(string message)
        {
            this.message = message;
        }

        public CheckUserRegistration()
        {
        }

        public string checkForFirstName()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        public string checkForLastName()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        public string checkForEmail()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        public string checkForMobile()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        public string checkForPassword()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }

        public string checkMultipleEntriesOfEmail(string email1, string email2, string email3, string email4)
        {
            UserRegistration userRegistration = new UserRegistration();
            bool emailForEntry1 = userRegistration.ValidateEmail(email1);
            bool emailForEntry2 = userRegistration.ValidateEmail(email2);
            bool emailForEntry3 = userRegistration.ValidateEmail(email3);
            bool emailForEntry4 = userRegistration.ValidateEmail(email4);
            if (emailForEntry1 && emailForEntry2 && emailForEntry3 && emailForEntry4)
                return "Entry is successful";
            else
                return "Entry is not successful";
        }

       
    }
}
    

    

    

