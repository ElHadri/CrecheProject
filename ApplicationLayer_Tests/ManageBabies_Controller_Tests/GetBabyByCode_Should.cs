using System;
using ApplicationLayer.Services;
using Xunit;

namespace Babysit.ApplicationLayer_Tests.ManageBabies_Controller_Tests
{
    public class GetBabyByCode_Should
    {

        [Fact]
        public void Return_an_info_message_when_no_baby_corresponds_to_the_provided_code()
        {
            //Arrange
            var sut = new ManageBabies_Controller();
            var codeNotYetAssigned = "";
            var expectedInfoMessage = $"No baby with code {codeNotYetAssigned} exists !!";
            var actualInfoMessage = "";

            //Act
            try
            {
                sut.GetBabyByCode(codeNotYetAssigned);
            }
            catch (Exception ex)
            {
                actualInfoMessage = ex.Message;
            }

            //Assert
            Assert.Equal(expectedInfoMessage, actualInfoMessage);
        }

        [Fact]
        public void Return_details_about_a_baby_having_the_code_13()
        {
            // Arrange
            var sut = new ManageBabies_Controller();
            var expectedFirstName = "Imrane";
            var expectedLastName = "El Hadri";
            var expectedBirthday = new DateTime(2016, 03, 11);
            var expectedIsActive = true;


            // Act
            var retrievedBaby = sut.GetBabyByCode("13");
            var actualFirstName = retrievedBaby.FirstName;
            var actualLastName = retrievedBaby.LastName;
            var actualBirthday = retrievedBaby.Birthday;
            var actualIsActive = retrievedBaby.IsActive;

            // Assert
            Assert.Equal(expectedFirstName, actualFirstName);
            Assert.Equal(expectedLastName, actualLastName);
            Assert.Equal(expectedBirthday, actualBirthday);
            Assert.Equal(expectedIsActive, actualIsActive);
        }
    }
}