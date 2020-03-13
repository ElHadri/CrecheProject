using System;
using System.Collections.Generic;
using Babysit.ApplicationLayer;

// a precondition can never contradict the conceptual model
namespace ApplicationLayer.Services
{
    // UC_Prec: user authorized
    // UC_Post: 
    public class ManageBabies_Controller  // les methodes jouent un double role (UC & system operation)
    {
        // Prec: --none
        // Rslt: bool  ( true if "the baby found" / false if "the baby not found")
        public bool isBabyIdExists(string aBabyCardId)
        {
            //...
            return true;
        }

        //****************************************************************************************************
        // pre: 
        // mistress[aMistressNickName] -> notEmpty() and
        // baby[aBabyId] -> isEmpty() [This does not invalidate the exception that could be raised by the invariant, 
        // but it assures that this specific operation is not going to raise that exception]

        //¨post: 
        // newBaby.newInstanceOf(Baby) and

        // newBaby^setFirstName(aFirstName) and
        // newBaby^setLastName(aLastName) and
        // newBaby^setBirthday(aBirthday) and

        // newBaby^addMistress(mistress[aMistressNickName]) and
        // self^addBaby(newBaby)
        public void CreateBaby(
            string aBabyCardId,
            string aFirstName,
            string aLastName,
            DateTime aBirthday,
            string aMistressNickName
            //,
            //List<string> aGuardiansFirstName /*comment manipuler ça ?*/
            )
        {
            //...
        }

        //****************************************************************************************************
        // body:
        //  Tuple{
        //      babyCode = aBabyCode,
        //      firstName = baby[aBabyCode].FirstName,
        //      lastName = baby[aBabyCode].LastName,
        //      birthday = baby[aBabyCode].Birthday,
        //      isActive = baby[aBabyCode].IsActive,
        //  }
        public BabyDTO GetBabyByCode(string aBabyCardId)
        {
            // as a DB
            if (aBabyCardId == "13")
            {
                var newBaby = new BabyDTO()
                {
                    BabyCardId = "13",
                    FirstName = "Imrane",
                    LastName = "El Hadri",
                    Birthday = new DateTime(2016, 03, 11),
                    IsActive = true
                };

                return newBaby;
            }
            else
            {
                throw new Exception($"No baby with code {aBabyCardId} exists !!");
            }
        }

        //****************************************************************************************************
        //def: 
        //  aBaby=baby[aBabyId]
        //pre:
        //  aBaby -> notEmpty()
        //post: 
        //  aBaby^setFirstName(aFirstName) and
        //  aBaby^setLastName(aLastName) and

        //  aBaby^removeMistress(mistress[@aMistressNickName]) and
        //  aBaby^addMistress(mistress[aMistressNickName])
        public void UpdateBaby(int aBabyId, string aFirstName, string aLastName, string aMistressNickName)
        {
        }

        //****************************************************************************************************
        //pre:
        //  baby[aBabyCode] -> notEmpty() and
        //post:
        //  baby[aBabyCode]^destroy()
        //exception: 
        //  baby[aBabyId].guardian.baby   ->   exists( aGuardian|aGuardian.baby -> isEmpty() )
        //      implies self^throw(‘The baby cannot be deleted because at least one guardian of him is connected to other baby)
        public void DeleteBaby(int aBabyCode)
        {
            // as a DB
            var newBaby = new BabyDTO();
            if (aBabyCode == 1)
            {
                // to do
            }
            else
            {
                throw new Exception($"No baby with code {aBabyCode} exists !!");
            }
        }

        //****************************************************************************************************
        // pre:
        //  baby[aBabyId] -> notEmpty() and
        //post:
        //  baby[aBabyId]^setIsActive(false)
        //exception: 
        //  baby[aBabyId].guardian -> notEmpty()  // not needed because none will be actually deleted !!
        // and 
        //  baby[aBabyId].guardian.baby   ->   exists( aGuardian|aGuardian.baby -> isEmpty() )
        //      implies self^throw(‘The baby cannot be inactivated because at least one guardian of him is connected to other baby)
        public void InactivateBaby(int aBabyId)
        {
            //...
        }

        //****************************************************************************************************
        // body:
        //  self.baby -> collect(aBaby|
        //      Tuple{
        //          babyId = aBaby.BabyId
        //          firstName = aBaby.FirstName
        //          lastName = aBaby.LasttName
        //          birthday = aBaby.Birthday
        //      })
        public List<BabyDTO> GetAllBabies()
        {
            //...
            return new List<BabyDTO>();
        }
    }
}