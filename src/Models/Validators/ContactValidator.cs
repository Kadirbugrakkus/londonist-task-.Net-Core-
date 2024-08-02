using CrmApp.Models.Requests;
using FluentValidation;

namespace CrmApp.Models.Validators;

public class ContactRequestValidator : AbstractValidator<ContactRequest>
{
    public ContactRequestValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name is required")
            .Length(1, 255).WithMessage("First name must be less than 255 characters");

        RuleFor(x => x.LastName).NotEmpty().WithMessage("Last name is required")
            .Length(1, 255).WithMessage("Last name must be less than 255 characters");

        RuleFor(x => x.CountryId).NotEmpty().WithMessage("CountryId is required")
            .GreaterThan(0).WithMessage("CountryId must be a valid number");

        RuleFor(x => x.Phone).NotEmpty().WithMessage("Phone is required")
            .Length(1, 20).WithMessage("Phone must be less than 20 characters");

        RuleFor(x => x.MeetingDate).NotEmpty().WithMessage("MeetingDate is required");

        RuleFor(x => x.Budget).NotEmpty().WithMessage("Budget is required")
            .Length(1, 255).WithMessage("Budget must be a set of characters");

        RuleFor(x => x.BedroomsCount).NotEmpty().WithMessage("BedroomsCount is required")
            .GreaterThanOrEqualTo(1).WithMessage("BedroomsCount must be at least 1");
    }
}