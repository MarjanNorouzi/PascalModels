using FluentValidation;
using PascalModels.Models;

namespace PascalModels.Validations
{
    public class SubListReportByDetCodeReqValidator : AbstractValidator<SubListReportByDetCodeReq>
    {
        public SubListReportByDetCodeReqValidator()
        {
            When(p =>
                       (string.IsNullOrWhiteSpace(p.DetCode)),
                       () =>
                       {
                           RuleFor(x => x).NotEmpty().WithMessage("کد تفصیل را وارد کنید"); //Insert 'DetCode'.
                       });

            When(p =>
                       (!string.IsNullOrWhiteSpace(p.DetCode)),
                       () =>
                       {
                           RuleFor(x => x.DetCode).MaximumLength(6).Must(ValidateDetCode).WithMessage("مقدار کد تفصیلی فقط می تواند عدد صحیح باشد");
                           //'DetCode' Can Be Integer
                           //check new name
                           //Include(new FromSanadNoToNoReqValidator());
                       });
        }
        private bool ValidateDetCode(string detCode)
        {
            return int.TryParse(detCode, out int b);
        }
    }
}
