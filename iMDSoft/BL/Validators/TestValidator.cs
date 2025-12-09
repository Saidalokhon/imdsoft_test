using BL.Models;
using FluentValidation;

namespace BL.Validators
{
    public class TestValidator : AbstractValidator<Test>
    {
        public TestValidator()
        {
            RuleFor(t => t.TestName)
                .NotEmpty().WithMessage("Test name is required.")
                .MaximumLength(50).WithMessage("Test name cannot exceed 100 characters.")
                .MinimumLength(2).WithMessage("Test name cannot be less than 2 characters.");

            RuleFor(t => t.TestDate)
                .LessThan(DateTime.Now).WithMessage("Test date cannot be greater than todays date.");

            RuleFor(t => t.Result)
                .GreaterThanOrEqualTo(0).WithMessage("Result must be greater than or equal to 0.")
                .LessThan(1000).WithMessage("Result must be less than 1000.");
        }
    }
}
