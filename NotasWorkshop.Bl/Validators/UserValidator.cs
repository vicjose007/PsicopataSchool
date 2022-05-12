using FluentValidation;
using NotasWorkshop.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasWorkshop.Bl.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {

            RuleFor(u => u.Name).NotNull().NotEmpty();
            RuleFor(u => u.Password).NotNull().NotEmpty().MaximumLength(10).MinimumLength(3);

        }

    }
}
