using babies.DomainLayer.Object_model;
using System;
using System.Collections.Generic;
using System.Text;

// a precondition can never contradict the conceptual model
namespace babies.ApplicationLayer.Application_services
{
    // UC_Prec: user authorized
    // UC_Post: 
    public static class CRUD_babies_UC_Controller  // les methodes jouent double role (UC & system operation)
    {
        // Prec: |babies already registered| = n  (n >= 0)            (Complementary constraint)
        // Post: |babies registered| = n+1
        // Excp: the baby to register already exists ==> Post: |babies registered| = n      (is a Parameter guarantee)
        public static void RegisterBaby(Baby baby)
        {
            //...
        }

        // Prec: Nil
        // Rslt: Baby
        // Info: the baby not exists ==> Rslt: void
        public static Baby GetBabyById(int babyId)
        {
            //...
            return new Baby();
        }

        // Prec: Nil
        // Post: baby updated
        // Excp: the baby do not exists ==> Post: Nil
        // Excp: the baby exists but trying to change his Id ==> Post: baby not updated
        public static void ChangeBaby(Baby newBaby)
        {
            var existingBaby = GetBabyById(newBaby.BabyId);
            //...
        }

        // Prec: |babies already registered| = n  (n >= 0)
        // Post: if (n=0) then (|babies registered| = 0) else (|babies registered| = n-1)
        // Info: baby not found ==> Post: |babies registered| = n
        public static void DeleteBaby(int babyId) 
        {
            //...
        }

        // Prec: Nil
        // Rslt: Baby*
        // Info: no babies registered ==> Rslt: void
        public static void GetAllBabies() 
        {
            //...
        }
    }
}
