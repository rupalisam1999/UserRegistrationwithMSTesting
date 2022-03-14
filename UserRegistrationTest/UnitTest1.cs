using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationWithMSTesting;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessfulForFirstName(string message)
        {
            CheckUserRegistration userRegistration = new CheckUserRegistration(message);
            string expected = userRegistration.checkForFirstName();
            Assert.AreEqual(expected, "Entry is successful");
        }
        [TestMethod]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessfulForFirstName(string message)
        {
            CheckUserRegistration userRegistration = new CheckUserRegistration(message);
            string expected = userRegistration.checkForFirstName();
            Assert.AreEqual(expected, "Entry is not successful");
        }
        [TestMethod]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessfulForLastName(string message)
        {
            CheckUserRegistration userRegistration = new CheckUserRegistration(message);
            string expected = userRegistration.checkForLastName();
            Assert.AreEqual(expected, "Entry is successful");
        }
        [TestMethod]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessfulForLastName(string message)
        {
            CheckUserRegistration userRegistration = new CheckUserRegistration(message);
            string expected = userRegistration.checkForLastName();
            Assert.AreEqual(expected, "Entry is not successful");
        }
        [TestMethod]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessfulForEmail(string message)
        {
            CheckUserRegistration userRegistration = new CheckUserRegistration(message);
            string expected = userRegistration.checkForEmail();
            Assert.AreEqual(expected, "Entry is successful");
        }
        [TestMethod]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessfulForEmail(string message)
        {
            CheckUserRegistration userRegistration = new CheckUserRegistration(message);
            string expected = userRegistration.checkForEmail();
            Assert.AreEqual(expected, "Entry is not successful");
        }
        [TestMethod]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessfulForMobile(string message)
        {
            CheckUserRegistration userRegistration = new CheckUserRegistration(message);
            string expected = userRegistration.checkForMobile();
            Assert.AreEqual(expected, "Entry is successful");
        }
        [TestMethod]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessfulForMobile(string message)
        {
            CheckUserRegistration userRegistration = new CheckUserRegistration(message);
            string expected = userRegistration.checkForMobile();
            Assert.AreEqual(expected, "Entry is not successful");
        }
        [TestMethod]
        [DataRow("Happy")]
        public void GivenMessage_WhenHappy_ReturnEntrySucessfulForPassword(string message)
        {
            CheckUserRegistration userRegistration = new CheckUserRegistration(message);
            string expected = userRegistration.checkForPassword();
            Assert.AreEqual(expected, "Entry is successful");
        }
        [TestMethod]
        [DataRow("Sad")]
        public void GivenMessage_WhenSad_ReturnEntryUnSucessfulForPassword(string message)
        {
            CheckUserRegistration userRegistration = new CheckUserRegistration(message);
            string expected = userRegistration.checkForPassword();
            Assert.AreEqual(expected, "Entry is not successful");
        }

        [TestMethod]
        public void GivenParameterizedTest_ToValidateMultipleEntries_ReturnEntryIsSucessful()
        {
            CheckUserRegistration userRegistration = new CheckUserRegistration();
            var result = userRegistration.checkMultipleEntriesOfEmail("abc@yahoo.com", "abc-100@yahoo.com", "abc@gmail.com.com", "abc+100@gmail.com");
            Assert.AreEqual(result, "Entry is  successful");
        }
        //UC-13
        [TestMethod]
        [DataRow("Rupali")]
        public void GivenFirstName_Whenvalid_ThenShouldReturnTrueUsingLambda(string firstName)
        {
            UserRegistration userRegistrationRegex = new UserRegistration();
            bool validateFirstName = userRegistrationRegex.isValidFirstName(firstName);
            Assert.AreEqual(true, validateFirstName);
        }
        /// <summary>
        /// Givens the last name when valid then should return true using lambda.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        [TestMethod]
        [DataRow("Sangale")]
        public void GivenLastName_WhenValid_ThenShouldReturnTrueUsingLambda(string lastName)
        {
            UserRegistration userRegistrationRegex = new UserRegistration();
            bool validateLastName = userRegistrationRegex.isValidLastName(lastName);
            Assert.AreEqual(true, validateLastName);
        }
        /// <summary>
        /// Givens the email when valid then should return true using lambda.
        /// </summary>
        /// <param name="email">The email.</param>
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        public void GivenEmail_WhenValid_ThenShouldReturnTrueUsingLambda(string email)
        {
            UserRegistration userRegistrationRegex = new UserRegistration();
            bool validateEmail = userRegistrationRegex.isValidEmail(email);
            Assert.AreEqual(true, validateEmail);
        }
        /// <summary>
        /// Givens the mobile format when valid then should return true using lambda.
        /// </summary>
        /// <param name="mobileFormat">The mobile format.</param>
        [TestMethod]
        [DataRow("91 8149713160")]
        public void GivenMobileFormat_WhenValid_ThenShouldReturnTrueUsingLambda(string mobileFormat)
        {
            UserRegistration userRegistrationRegex = new UserRegistration();
            bool validateMobileFormat = userRegistrationRegex.isValidMobileNumber(mobileFormat);
            Assert.AreEqual(true, validateMobileFormat);
        }
        /// <summary>
        /// Givens the password format when valid then should return true using lambda.
        /// </summary>
        /// <param name="preDefinedPassword">The pre defined password.</param>
        [TestMethod]
        [DataRow("Rupali@123")]
        public void GivenPasswordFormat_WhenValid_ThenShouldReturnTrueUsingLambda(string preDefinedPassword)
        {
            UserRegistration userRegistrationRegex = new UserRegistration();
            bool validatePassword = userRegistrationRegex.isValidPassword(preDefinedPassword);
            Assert.AreEqual(true, validatePassword);
        }
    }
}

    

