using LLC.Application.Features.Brands.Commands.AddEdit;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace LLC.Application.Validators.Features.Brands.Commands.AddEdit
{
    public class AddEditBrandCommandValidator : AbstractValidator<AddEditBrandCommand>
    {
        public AddEditBrandCommandValidator(IStringLocalizer<AddEditBrandCommandValidator> localizer)
        {
            RuleFor(request => request.FirstName)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["First Name is required!"]);
            RuleFor(request => request.LastName)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Last Name is required!"]);
            RuleFor(request => request.Phone)
            .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Phone is required!"]);
            RuleFor(request => request.Email)
            .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["EMail is required!"]);

            //RuleFor(request => request.Tax)
            //    .GreaterThan(0).WithMessage(x => localizer["Tax must be greater than 0"]);
        }
    }
}