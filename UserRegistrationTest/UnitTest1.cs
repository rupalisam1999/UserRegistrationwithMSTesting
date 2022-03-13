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
    }
}