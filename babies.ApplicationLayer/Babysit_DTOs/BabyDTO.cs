using System;
using babies.DomainLayer.Object_model.Primitive_Types;

namespace Babysit.ApplicationLayer 
{
    public class BabyDTO
    {
        public int BabyCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
