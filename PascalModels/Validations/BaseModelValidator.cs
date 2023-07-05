using FluentValidation;
using PascalModels.Models.BaseModels;

namespace PascalModels.Validations
{
    public class BaseModelValidator : AbstractValidator<BaseModel>
    {
        public BaseModelValidator()
        {
            RuleFor(x => x.CompanyCode).NotEmpty().NotNull().WithMessage("کد کمپانی نمی تواند خالی باشد")
                                       .Must(NumberValidation).WithMessage("کد کمپانی باید دو رقمی باشد");

            RuleFor(x => x.FinancialYear).NotEmpty().NotNull().WithMessage("سال مالی نمی تواند خالی باشد")
                                         .Must(NumberValidation).WithMessage("سال مالی باید دو رقمی باشد");
        }

        private bool NumberValidation(string number)
        {
            return int.TryParse(number, out var result) && result is < 100 and > 0;
        }
    }
}
