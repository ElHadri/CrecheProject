using babies.DomainLayer.Object_model;

using System;
using System.Collections.Generic;

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
        }

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

        // Prec: --none
        // Rslt: Baby  ||  nothing ( if "the baby not found" )
        // Warn: if "the baby not found"
        public static Baby GetBabyById(BabyId aBabyId)
        {
            //...
        }

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
        // pre:
        //  baby[aBabyId] -> notEmpty() and
        //post:
        //  baby[aBabyId]^destroy()
        //exception: 
        //  baby[aBabyId].guardian -> notEmpty() 
        // and 
        //  baby[aBabyId].guardian.baby   ->   exists( aGuardian|aGuardian.baby -> isEmpty() )
        //      implies self^throw(‘The baby cannot be deleted because at least one guardian of him is connected to other baby)
        public static void DeleteBaby(BabyId aBabyId)
        {
            //...
        }


        //****************************************************************************************************


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


        // Prec: Nil
        // Rslt: Baby* || nothing ( if "no babies registered" )
        // Warn: if "no babies registered"
        public static List<Baby> GetAllBabies()
        {
            //...
            return new List<Baby>();
        }
    }

}


// pre: 
// let nbOfRegisteredBabies : int  =  self.baby -> size()
// self.baby -> select (b|b.aBabyId = aBaby.aBabyId) -> size()=0  [Parameter guarantee/semantic verification]
//and 