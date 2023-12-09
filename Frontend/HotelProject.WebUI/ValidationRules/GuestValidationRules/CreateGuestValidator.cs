using FluentValidation;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class CreateGuestValidator : AbstractValidator<CreateGuestDto>
    {
        public CreateGuestValidator()
        {
            RuleFor(a => a.Name).NotEmpty().WithMessage("This field must not empty");
            RuleFor(a => a.Surname).NotEmpty().WithMessage("This field must not empty");
            RuleFor(a => a.City).NotEmpty().WithMessage("This field must not empty");

            RuleFor(a => a.Name).MinimumLength(2).WithMessage("Name will be minimum 2 character");
            RuleFor(a => a.Surname).MinimumLength(2).WithMessage("Surname will be minimum 2 character");
            RuleFor(a => a.City).MinimumLength(2).WithMessage("City will be minimum 2 character");

            RuleFor(a => a.Name).MaximumLength(2).WithMessage("Name will be MaximumLength 2 character");
            RuleFor(a => a.Surname).MaximumLength(2).WithMessage("Surname will be MaximumLength 2 character");
            RuleFor(a => a.City).MaximumLength(2).WithMessage("City will be MaximumLength 2 character");
        }
    }
}
