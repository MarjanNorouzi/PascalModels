using FluentValidation;
using PascalModels.Models.BaseModels;

namespace PascalModels.Validations
{
    public class BaseModelValidation : AbstractValidator<BaseModel>
    {
        public BaseModelValidation()
        {
            RuleFor(x => x.CompanyCode).NotEmpty().NotNull().WithMessage("کد کمپانی نمی تواند خالی باشد")
                                       .Must(NumberValidation).WithMessage("کد کمپانی باید دو رقمی باشد");

            RuleFor(x => x.FinancialYear).NotEmpty().NotNull().WithMessage("سال مالین نمی تواند خالی باشد")
                                         .Must(NumberValidation).WithMessage("سال مالی باید دو رقمی باشد");
        }

        private bool NumberValidation(int number)
        {
            return number is < 100 and > 0;
        }
    }
}
