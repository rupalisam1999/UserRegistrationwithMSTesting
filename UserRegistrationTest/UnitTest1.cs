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
    }
}
