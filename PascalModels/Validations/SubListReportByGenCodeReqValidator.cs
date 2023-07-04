using FluentValidation;
using PascalModels.Models;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class SubListReportByGenCodeReqValidator : AbstractValidator<SubListReportByGenCodeReq>
    {
        public SubListReportByGenCodeReqValidator()
        {
            //کد کل نمیتواند خالی باشد، با استفاده از کد کل یک لیستی بر اساس کد معین بر  میگردد

            RuleFor(x => x.GeneralCode)
                .NotEmpty().WithMessage("کد کل را وارد کنید") //Insert 'GeneralCode'.
                .Length(4, 4).WithMessage("کد کل' باید 4 رقم باشد'")
                .Must(ValidateGenCode).WithMessage("مقدار کد کل فقط می تواند شامل اعداد باشد"); //General Code Can Be Integer

            Include(new NumberDateFilterReqValidator());
        }

        private bool ValidateGenCode(string generalCode)
        {
            return int.TryParse(generalCode, out _);
        }
    }
}
