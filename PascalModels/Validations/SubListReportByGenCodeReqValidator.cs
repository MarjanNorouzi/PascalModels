using FluentValidation;
using PascalModels.Models;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class SubListReportByGenCodeReqValidator : AbstractValidator<SubListReportByGenCodeReq>
    {
        public SubListReportByGenCodeReqValidator()
        {
            /// <summary>
            /// <para><em>لیست معین بر اساس کد کل</em></para>
            /// <para>با استفاده از کد کل یک لیست کد معین بر  میگردد</para> 
            /// <para>کد کل نمیتواند خالی باشد و همچنین باید شامل 4 رقم باشد</para>
            /// </summary>

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
