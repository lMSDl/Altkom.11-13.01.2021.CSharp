﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Validators
{
    public class TeacherValidator : PersonValidator<Teacher>
    {
        public TeacherValidator()
        {
            RuleFor(x => x.Specialization).Length(1, 15).NotNull();
        }
    }
}
