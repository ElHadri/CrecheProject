using System;

namespace Babysit.ApplicationLayer
{
    public class GuardianDTO
    {
        public string GuardianCardId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; } = true;
        public Kinship Kinship { get; set; }
    }

    public enum Kinship
    {
        Father, Mother, Other
    }
}
