using FluentValidation;
using PascalModels.Models;

namespace PascalModels.Validations
{
    public class InsertDetReqValidator : AbstractValidator<InsertDetReq>
    {
        //افزودن تفصیل
        public InsertDetReqValidator()
        {
            RuleFor(x => x.DetCode)
                .NotEmpty().NotNull().WithMessage("کد تفصیل نمی تواند خالی باشد")
                .Length(4, 4).WithMessage("کد تفصیل باید 4 رقم باشد")
                .Must(ValidateCode).WithMessage("مقدار کد تفصیل فقط می تواند شامل اعداد باشد");

            RuleFor(x => x.DetName)
                .NotEmpty().NotNull().WithMessage("نام تفصیل نمی تواند خالی باشد")
                .MaximumLength(50).WithMessage("بیش از 50 کاراکتر مجاز نمی باشد");
        }

        private bool ValidateCode(string code)
        {
            return int.TryParse(code, out _);
        }
    }
}
