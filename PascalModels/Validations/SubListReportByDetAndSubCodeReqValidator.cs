﻿using FluentValidation;
using PascalModels.Models;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class SubListReportByDetAndSubCodeReqValidator : AbstractValidator<SubListReportByDetAndSubCodeReq>
    {
        public SubListReportByDetAndSubCodeReqValidator()
        {
            When(p =>
                       (string.IsNullOrWhiteSpace(p.SubCode)),
                       () =>
                       {
                           RuleFor(x => x).NotEmpty().WithMessage("کد معین نمی تواند خالی باشد"); //'SubCode' Can't Be Null.
                       });

            When(p =>
                       (!string.IsNullOrWhiteSpace(p.SubCode) && !string.IsNullOrWhiteSpace(p.DetCode)),
                       () =>
                       {
                           RuleFor(x => x.SubCode).MaximumLength(10).Must(ValidateCode).WithMessage("مقدار کد معین فقط می تواند عدد صحیح باشد"); //'SubCode' Should Be Integer
                           RuleFor(x => x.DetCode).MaximumLength(8).Must(ValidateCode).WithMessage("مقدار کد تفصیلی فقط می تواند عدد صحیح باشد"); //'DetCode' Should Be Integer
                           Include(new NumberDateFilterReqValidator());
                       });

            When(p =>
                      (!string.IsNullOrWhiteSpace(p.SubCode) && string.IsNullOrWhiteSpace(p.DetCode)),
                      () =>
                      {
                          RuleFor(x => x.SubCode).MaximumLength(10).Must(ValidateCode).WithMessage("مقدار کد معین فقط می تواند عدد صحیح باشد"); //'SubCode' Should Be Integer
                          Include(new NumberDateFilterReqValidator());
                      });
        }
        private bool ValidateCode(string code)
        {
            return int.TryParse(code, out int b);
        }
    }
}