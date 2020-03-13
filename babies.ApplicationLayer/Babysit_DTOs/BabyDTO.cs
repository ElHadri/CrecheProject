﻿using System;

namespace Babysit.ApplicationLayer
{
    public class BabyDTO
    {
        public string BabyCardId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
