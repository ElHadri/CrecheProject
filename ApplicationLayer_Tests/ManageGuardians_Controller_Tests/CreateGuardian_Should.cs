using System;
using System.Collections.Generic;
using System.Text;
using ApplicationLayer.Helpers;
using ApplicationLayer.Services;
using Babysit.ApplicationLayer;
using Xunit;

namespace ApplicationLayer_Tests.ManageGuardians_Controller_Tests
{
    public class CreateGuardian_Should
    {
        // Happy path (Postcondition test)
        [Fact]
        public void Register_the_guardian_and_return_a_feedback_that_confirms_that_the_operation_was_successful()
        {
            // Arrange
            var sut = new ManageGuardians_Controller();

            var expectedGuardianCardId = "B21453135";
            var expectedFirstName = "Adil";
            var expectedLastName = "El Hadri";
            var expectedIsActive = true;
            var expectedKinship = Kinship.Father;

            var expectedFeedbackIsOk = true;
            var expectedFeedbacMessage = "A guardian is registered :)";


            // Act
            if (!sut.CheckExistenceByIdCard("B21453135").IsOk)
            {
                var aFeedback = sut.CreateGuardian(
                      aGuardianCardId: "B21453135",
                      aFirstName: "Adil",
                      aLastName: "El Hadri",
                      isActive: true,
                      aKinship: Kinship.Father);
                var aRegisteredGuardian = sut.GetGuardianByIdCard("B21453135");

                // Assert
                Assert.Equal(expectedFeedbackIsOk, aFeedback.IsOk);
                Assert.Equal(expectedFeedbacMessage, aFeedback.Message);

                Assert.Equal(expectedGuardianCardId, aRegisteredGuardian.GuardianCardId);
                Assert.Equal(expectedFirstName, aRegisteredGuardian.FirstName);
                Assert.Equal(expectedLastName, aRegisteredGuardian.LastName);
                Assert.Equal(expectedIsActive, aRegisteredGuardian.IsActive);
                Assert.Equal(expectedKinship, aRegisteredGuardian.Kinship);
            }
        }
    }
}
