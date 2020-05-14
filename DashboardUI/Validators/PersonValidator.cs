using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using ModelLibrary;

namespace DashboardUI.Validators
{
    class PersonValidator : AbstractValidator<PersonModel>
    {

        public PersonValidator()
        {
            RuleFor(p => p.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is empty.")
                .Length(2, 50).WithMessage("Length ({TotalLength}) of {PropertyName} invalid.")
                .Must(BeValidName).WithMessage("{PropertyName} contains invalid characters.");

            RuleFor(p => p.LastName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is empty.")
                .Length(2, 50).WithMessage("Length ({TotalLength}) of {PropertyName} invalid.")
                .Must(BeValidName).WithMessage("{PropertyName} contains invalid characters.");

            RuleFor(p => p.DateOfBirth)
                .Must(BeValidAge).WithMessage("Invalid {PropertyName}.");

            RuleFor(p => p.AccountNumber)
                .Must(BeValidAccountNumber).WithMessage("{PropertyName} is too low.");
        }

        protected bool BeValidName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(Char.IsLetter);
        }

        protected bool BeValidAge(DateTime date)
        {
            int currentYear = DateTime.Now.Year;
            int dobYear = date.Year;

            if(dobYear <= currentYear && dobYear > (currentYear - 120))
            {
                return true;
            }

            return false;
        }

        protected bool BeValidAccountNumber(int accountNumber)
        {
            if(accountNumber >= 100)
            {
                return true;
            }

            return false;
        }
    }
}
