using NUnit.Framework;
using UserRegistrationProblem;

namespace UserRegistrationProblemTest
{
    [TestFixture]
    public class ValidationTest
    {
        private Validation validation;

        [SetUp]
        public void Setup()
        {
            validation = new Validation();
        }

        [Test]
        public void GivenFirstName_WhenValid_ShouldReturnTrue()
        {
            string firstName = "Shrikant";
            bool result = validation.ValidateFirstName(firstName);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenFirstName_WhenInvalid_ShouldReturnFalse()
        {
            string firstName = "sds";
            bool result = validation.ValidateFirstName(firstName);
            Assert.IsFalse(result);
        }

        [Test]
        public void GivenLastName_WhenValid_ShouldReturnTrue()
        {
            string lastName = "Don";
            bool result = validation.ValidateLastName(lastName);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenLastName_WhenInvalid_ShouldReturnFalse()
        {
            string lastName = "do";
            bool result = validation.ValidateLastName(lastName);
            Assert.IsFalse(result);
        }

        [Test]
        public void GivenEmail_WhenValid_ShouldReturnTrue()
        {
            string email = "abc.xyz@bl.co.in";
            bool result = validation.ValidateEmail(email);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenEmail_WhenInvalid_ShouldReturnFalse()
        {
            string email = "abc.xyz@bl.co.";
            bool result = validation.ValidateEmail(email);
            Assert.IsFalse(result);
        }

        [Test]
        public void GivenMobileNumber_WhenValid_ShouldReturnTrue()
        {
            string mobileNumber = "91 7743840611";
            bool result = validation.ValidateMobileNumber(mobileNumber);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenMobileNumber_WhenInvalid_ShouldReturnFalse()
        {
            string mobileNumber = "9960572469";
            bool result = validation.ValidateMobileNumber(mobileNumber);
            Assert.IsFalse(result);
        }

        [Test]
        public void GivenPassword_WhenValid_ShouldReturnTrue()
        {
            string password = "Abc@1234";
            bool result = validation.ValidatePassword(password);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenPassword_WhenInvalid_ShouldReturnFalse()
        {
            string password = "abc123";
            bool result = validation.ValidatePassword(password);
            Assert.IsFalse(result);
        }
    }
}
