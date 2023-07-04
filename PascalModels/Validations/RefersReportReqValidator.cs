﻿using FluentValidation;
using PascalModels.Models;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class RefersReportReqValidator : AbstractValidator<RefersReportReq>
    {
        public RefersReportReqValidator()
        {
            //کد معین نمیتواند خالی باشد
            //کد تفصیل اختیاری میباشد
            //با استفاده از کد معین و تفصیل گزارش عطف ها بر  میگردد

            RuleFor(x => x.SubCode)
                         .NotEmpty().WithMessage("کد معین نمی تواند خالی باشد")
                         .Length(6, 6).WithMessage("کد معین باید 6 رقم باشد")
                         .Must(ValidateCode).WithMessage("مقدار کد معین فقط می تواند شامل اعداد باشد"); //'SubCode' Should Be Integer

            Include(new NumberDateFilterReqValidator());

            When(p => !string.IsNullOrWhiteSpace(p.SubCode) && !string.IsNullOrWhiteSpace(p.DetCode),
                     () =>
                     {
                         RuleFor(x => x.DetCode)
                                 .Length(4, 4).WithMessage("کد تفصیل باید 4 رقم باشد")
                                 .Must(ValidateCode).WithMessage("مقدار کد تفصیل فقط می تواند شامل اعداد باشد"); //'DetCode' Should Be Integer
                     });
        }

        private bool ValidateCode(string code)
        {
            return int.TryParse(code, out _);
        }
    }
}