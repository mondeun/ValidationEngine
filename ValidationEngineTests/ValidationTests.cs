using NUnit.Framework;
using ValidationEngine;

namespace ValidationEngineTests
{
    [TestFixture]
    public class ValidationTests
    {
        [Test]
        [TestCase("joe@apple.com")]
        [TestCase("mike@edument.se")]
        public void TrueForValidAddress(string email)
        {
            var sut = new Validator();

            var valid = sut.ValidateEmailAddress(email);

            Assert.IsTrue(valid, "email should be valid");
        }

        [Test]
        [TestCase("")]
        [TestCase("Test.com")]
        [TestCase("name@test")]
        [TestCase("name.test@com")]
        [TestCase("Name2015@test.com")]
        [TestCase("name@test2015.com")]
        public void FalseForInvalidAddress(string email)
        {
            var sut = new Validator();

            Assert.Throws<MyDumbEmailException>(() => sut.ValidateEmailAddress(email));
        }
    }
}
