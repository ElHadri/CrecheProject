using System;
using babies.DomainLayer.Object_model.Primitive_Types;

namespace babies.ApplicationLayer
{
    public class BabyDTO
    {
        public BabyId BabyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
