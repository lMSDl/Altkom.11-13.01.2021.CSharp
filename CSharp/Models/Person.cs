﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Person : Entity, ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; } = (Gender)3;

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
