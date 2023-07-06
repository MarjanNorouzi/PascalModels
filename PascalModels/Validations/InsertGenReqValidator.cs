using FluentValidation;
using PascalModels.Models;

namespace PascalModels.Validations
{
    public class InsertGenReqValidator : AbstractValidator<InsertGenReq>
    {
        /// <summary>
        /// <para><em>افزودن کل</em></para>
        /// </summary>
        public InsertGenReqValidator()
        {
            RuleFor(x => x.GroupCode)
                .NotEmpty().NotNull().WithMessage("کد گروه نمی تواند خالی باشد")
                .Length(2, 2).WithMessage("کد گروه باید 2 رقم باشد")
                .Must(ValidateCode).WithMessage("مقدار کد گروه فقط می تواند شامل اعداد باشد");


            RuleFor(x => x.GenCode)
                .NotEmpty().NotNull().WithMessage("کد کل نمی تواند خالی باشد")
                .Length(4,4).WithMessage("کد کل باید 4 رقم باشد")
                .Must(ValidateCode).WithMessage("مقدار کد کل فقط می تواند شامل اعداد باشد");

            RuleFor(x => x.GenName)
                .NotEmpty().NotNull().WithMessage("نام کل نمی تواند خالی باشد")
                .MaximumLength(50).WithMessage("بیش از 50 کاراکتر مجاز نمی باشد");
        }

        private bool ValidateCode(string code)
        {
            return int.TryParse(code, out _);
        }
    }
}
