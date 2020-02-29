﻿using System;
using System.Collections.Generic;
using babies.DomainLayer.Object_model.Primitive_Types;

// a precondition can never contradict the conceptual model
namespace babies.ApplicationLayer.Application_services
{
    // UC_Prec: user authorized
    // UC_Post: 
    public static class CRUD_babies_UC_Controller  // les methodes jouent un double role (UC & system operation)
    {
        // Prec: --none
        // Rslt: bool  ( true if "the baby found" / false if "the baby not found")
        public static bool isBabyIdExists(BabyId aBabyId)
        {
            //...
            return true;
        }

        //****************************************************************************************************
        // pre: 
        // nbOfRegisteredBabies >= 0  [Complementary constraint] and
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

        // nbOfRegisteredBabies = nbOfRegisteredBabies@pre + 1
        public static void CreateBaby(
            BabyId aBabyId,
            string aFirstName,
            string aLastName,
            DateTime aBirthday,
            string aMistressNickName,
            List<string> aGuardiansFirstName /*comment manipuler ça ?*/
            )
        {
            //...
        }

        //****************************************************************************************************
        // body:
        //  Tuple{
        //      babyId = aBabyId,
        //      firstName = baby[aBabyId].FirstName,
        //      lastName = baby[aBabyId].LastName,
        //      birthday = baby[aBabyId].Birthday,
        //      isActive = baby[aBabyId].IsActive,
        //  }
        public static BabyDTO GetBaby(BabyId aBabyId)
        {
            //...
            return new BabyDTO();
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
        public static void UpdateBaby(BabyId aBabyId, string aFirstName, string aLastName, string aMistressNickName)
        {
        }

        //****************************************************************************************************
        //pre:
        //  baby[aBabyId] -> notEmpty() and
        //post:
        //  baby[aBabyId]^destroy()
        //exception: 
        //  baby[aBabyId].guardian.baby   ->   exists( aGuardian|aGuardian.baby -> isEmpty() )
        //      implies self^throw(‘The baby cannot be deleted because at least one guardian of him is connected to other baby)
        public static void DeleteBaby(BabyId aBabyId)
        {
            //...
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
        public static void InactivateBaby(BabyId aBabyId)
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
        public static List<BabyDTO> GetAllBabies()
        {
            //...
            return new List<BabyDTO>();
        }
    }
}