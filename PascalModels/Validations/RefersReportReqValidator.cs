using FluentValidation;
using PascalModels.Models;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class RefersReportReqValidator : AbstractValidator<RefersReportReq>
    {
        public RefersReportReqValidator()
        {
            When(p =>
                      !string.IsNullOrWhiteSpace(p.DetCode),
                       () =>
                       {
                           RuleFor(x => x.DetCode).MaximumLength(8).Must(ValidateCode).WithMessage("مقدار کد تفصیلی فقط می تواند عدد صحیح باشد"); //'DetCode' Should Be Integer
                       });

            When(p =>
                       !string.IsNullOrWhiteSpace(p.SubCode),
                       () =>
                       {
                           RuleFor(x => x.SubCode).MaximumLength(10).Must(ValidateCode).WithMessage("مقدار کد معین فقط می تواند عدد صحیح باشد"); //'SubCode' Should Be Integer
                       });

            Include(new NumberDateFilterReqValidator());
        }
        private bool ValidateCode(string code)
        {
            return int.TryParse(code, out int b);
        }
    }
}