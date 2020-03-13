using System;
using System.Collections.Generic;
using System.Text;
using ApplicationLayer.Helpers;
using Babysit.ApplicationLayer;

namespace ApplicationLayer.Services
{
    public class ManageGuardians_Controller
    {
        public Feedback CreateGuardian(
            string aGuardianCardId,
            string aFirstName,
            string aLastName,
            bool isActive,
            Kinship aKinship)
        {
            // To Do

            return new Feedback() { IsOk = true, Message = "A guardian is registered :)" };
        }

        public Feedback CheckExistenceByIdCard( string aGuardianCardId)
        {
            // To Do

            return new Feedback() { IsOk = false, Message = "A guardian don't exists :(" };
        }


        public GuardianDTO GetGuardianByIdCard(string aGuardianCardId)
        {
            // To Do

            return new GuardianDTO()
            {
                GuardianCardId = "B21453135",
                FirstName = "Adil",
                LastName = "El Hadri",
                IsActive = true,
                Kinship = Kinship.Father
            };
        }
    }
}
