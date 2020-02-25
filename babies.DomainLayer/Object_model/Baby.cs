using System;
using System.Collections.Generic;
using System.Text;

namespace babies.DomainLayer.Object_model
{
    public class Baby
    {
        public int BabyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
    }
}
