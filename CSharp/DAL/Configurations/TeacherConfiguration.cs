﻿using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class TeacherConfiguration : PersonConfiguration<Teacher>
    {
        public TeacherConfiguration()
        {
            Property(x => x.Specialization).IsRequired().HasMaxLength(15);
            Ignore(x => x.FakeBool);
        }
    }
}
