using FluentValidation;
using PascalModels.Models;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class SubListReportByDetCodeReqValidator : AbstractValidator<SubListReportByDetCodeReq>
    {
        public SubListReportByDetCodeReqValidator()
        {
            //کد تفصیل نمیتواند خالی باشد، با استفاده از کد تفصیل یک لیست بر اساس کد معین بر  میگردد

            RuleFor(x => x.DetCode)
                .NotEmpty().WithMessage("'کد تفصیل' نمیتواند خالی باشد") //Insert 'DetCode'.
                .Length(4, 4).WithMessage("کد تفصیل' باید 4 رقم باشد'")
                .Must(ValidateDetCode).WithMessage("مقدار کد تفصیل فقط می تواند شامل اعداد باشد"); //'DetCode' Should Be Integer

            Include(new NumberDateFilterReqValidator());
        }

        private bool ValidateDetCode(string detCode)
        {
            return int.TryParse(detCode, out _);
        }
    }
}
