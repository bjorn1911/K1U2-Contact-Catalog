using Moq;
using Xunit;



namespace K1U2_Contact_Catalog.Tests
{
    public class ValidationServiceTests
    {
        [Fact]
        public void ReturnsFalse_WhenEmailIsInvalid()
        {
           
           string invalidEmail = "invalid-email";
           
           bool result = Services.ValidationService.IsValidEmail(invalidEmail);
           
           Assert.False(result);


        }
        [Fact]
        public void ReturnsTrue_WhenEmailIsValid()
        {

            string invalidEmail = "correct@email.yes";

            bool result = Services.ValidationService.IsValidEmail(invalidEmail);

            Assert.True(result);


        }
    }
}