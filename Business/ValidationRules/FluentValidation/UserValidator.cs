﻿using Core.Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public partial class BookValidator
    {
        public class UserValidator : AbstractValidator<User>
        {
            public UserValidator()
            {
                RuleFor(u => u.FirstName).NotEmpty();
                RuleFor(u => u.LastName).NotEmpty();
                RuleFor(u => u.Email).NotEmpty();
            }
        }
    }
}
