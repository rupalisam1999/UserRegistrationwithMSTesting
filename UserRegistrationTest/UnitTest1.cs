using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationWithMSTesting;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenWrongFirstName_ShouldReturnFalse()
        {
            string expected = "false";
            string firstName = "Rupali";
            UserRegistration userRegistration = new UserRegistration();
        
            bool actual = userRegistration.ValidateFirstName(firstName);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenWrongLastName_ShouldReturnFalse()
        {
            string expected = "false";
            string lastName = "Sangale";
            UserRegistration userRegistration = new UserRegistration();

            bool actual = userRegistration.ValidateLatName(lastName);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenWrongEmail_ShouldReturnFalse()
        {
            string expected = "false";
            string email = "San.abc@gmail.com";
            UserRegistration userRegistration = new UserRegistration();

            bool actual = userRegistration.ValidateEmail(email);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenWrongPhoneNo_ShouldReturnFalse()
        {
            string expected = "false";
            string phoneno = "91 9112674814";
            UserRegistration userRegistration = new UserRegistration();

            bool actual = userRegistration.ValidatePhoneNo(phoneno);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenWrongPassword_ShouldReturnFalse()
        {
            string expected = "false";
            string password = "pass@123";
            UserRegistration userRegistration = new UserRegistration();

            bool actual = userRegistration.ValidatePasswordRule4(password);
            Assert.AreEqual(expected, actual);
        }
    }
   

}
