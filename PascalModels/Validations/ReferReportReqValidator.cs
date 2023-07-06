using FluentValidation;
using Personal_Information.Models.ProcModels;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class ReferReportReqValidator : AbstractValidator<ReferReportReq>
    {
        public ReferReportReqValidator()
        {
            /// <summary>
            /// <para><em>گزارش عطف</em></para>
            /// <para>کد معین و تفصیل نمیتوانند خالی باشند و همچنین کد معین باید شامل 6 رقم و کد تفصیل شامل 4 رقم باشد</para> 
            /// <para>با استفاده از کد معین و تفصیل گزارش عطف بر  میگردد</para> 
            /// </summary>
            RuleFor(x => x.SubCode)
                .NotEmpty().WithMessage("کد معین نمی تواند خالی باشد")
                .Length(6, 6).WithMessage("کد معین باید 6 رقم باشد")
                .Must(ValidateCode).WithMessage("مقدار کد معین فقط می تواند شامل اعداد باشد"); //'SubCode' Should Be Integer

            RuleFor(x => x.DetCode)
                .NotEmpty().WithMessage("کد تفصیل نمی تواند خالی باشد")
                .Length(4, 4).WithMessage("کد تفصیل باید 4 رقم باشد")
                .Must(ValidateCode).WithMessage("مقدار کد تفصیل فقط می تواند شامل اعداد باشد"); //'DetCode' Should Be Integer

            Include(new NumberDateFilterReqValidator());
        }

        private bool ValidateCode(string code)
        {
            return int.TryParse(code, out _);
        }
    }
}