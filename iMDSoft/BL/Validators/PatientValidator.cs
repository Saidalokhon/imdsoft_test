using BL.Models;
using FluentValidation;

namespace BL.Validators
{
    public class PatientValidator : AbstractValidator<Patient>
    {
        public PatientValidator()
        {
            RuleFor(p => p.Name)
                .NotNull().WithMessage("Name is required.")
                .NotEmpty().WithMessage("Name cannot be empty.")
                .MaximumLength(50).WithMessage("Name cannot exceed 50 characters.")
                .MinimumLength(2).WithMessage("Name cannot be less than 2 characters.");

            RuleFor(p => p.DateOfBirth)
                .LessThan(DateTime.Now).WithMessage("Date of birth cannot be greater than todays date.")
                .GreaterThan(new DateTime(1899, 12, 31)).WithMessage("Date of birthe cannot be less than 1900.01.01.");

            RuleFor(p => p.Gender)
                .NotNull().WithMessage("Gender is required.")
                .NotEmpty().WithMessage("Gender cannot be empty.")
                .MaximumLength(50).WithMessage("Gender cannot exceed 50 characters.")
                .MinimumLength(2).WithMessage("Gender cannot be less than 2 characters.");
        }
    }
}
