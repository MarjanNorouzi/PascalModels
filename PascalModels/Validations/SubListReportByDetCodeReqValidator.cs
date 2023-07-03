﻿using FluentValidation;
using PascalModels.Models;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class SubListReportByDetCodeReqValidator : AbstractValidator<SubListReportByDetCodeReq>
    {
        public SubListReportByDetCodeReqValidator()
        {
            //کد تفصیل نمیتواند خالی باشد، با استفاده از کد تفصیل یک لیست بر اساس کد معین بر  میگردد
            When(p =>
                       (string.IsNullOrWhiteSpace(p.DetCode)),
                       () =>
                       {
                           RuleFor(x => x).NotEmpty().WithMessage("کد تفصیل را وارد کنید"); //Insert 'DetCode'.
                       }).Otherwise(() =>
                       {
                           RuleFor(x => x.DetCode).MaximumLength(8).WithMessage("بیش از 8 کاراکتر مجاز نمی باشد")
                                                  .Must(ValidateDetCode).WithMessage("مقدار کد تفصیلی فقط می تواند عدد صحیح باشد"); //'DetCode' Should Be Integer
                           Include(new NumberDateFilterReqValidator());
                       });
        }
        private bool ValidateDetCode(string detCode)
        {
            return int.TryParse(detCode, out int _);
        }
    }
}
