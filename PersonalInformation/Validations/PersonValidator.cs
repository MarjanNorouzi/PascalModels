using FluentValidation;
using PersonalInformation.Models;

namespace PersonalInformation.Validations
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Please specify a First Name");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Please specify a Last Name");
            RuleFor(x => x.Email).EmailAddress().NotEmpty().WithMessage($"{nameof(PersonValidator)} Please enter your Email");
            RuleFor(x => x.PhoneNumber).NotEmpty().When(x => x.Email is null);
            RuleFor(x => x.NationalCode).NotEmpty().Length(10);
            RuleFor(x => x.Age).Must(Validate_Age).WithMessage("Not Valid Age");
        }

        private bool Validate_Age(int age)
        {
            if (age < 18)
                return false;

            else
                return true;
        }
    }
}
