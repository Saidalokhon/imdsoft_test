using BL.Models;
using FluentValidation;

namespace BL.Validators
{
    public class ReportPeriodValidator : AbstractValidator<ReportPeriod>
    {
        public ReportPeriodValidator()
        {
            RuleFor(p => p.FromDate)
                .LessThanOrEqualTo(p => p.ToDate).WithMessage("FromDate must be earlier than ToDate.")
                .LessThan(DateTime.Now).WithMessage("FromDate cannot be in the future")
                .GreaterThanOrEqualTo(new DateTime(1899, 1, 1)).WithMessage("From date cannot be mo");

            RuleFor(p => p.ToDate)
                .GreaterThanOrEqualTo(p => p.FromDate).WithMessage("ToDate must be later than FromDate.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("ToDate cannot be in the future")
                .GreaterThanOrEqualTo(new DateTime(1899, 1, 1)).WithMessage("From date cannot be mo");
        }
    }
}
