using FluentValidation;
using PascalModels.Models;
using Personal_Information.Validators.SQLValidators;

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
                           RuleFor(x => x.DetCode).MaximumLength(8).Must(ValidateDetCode).WithMessage("مقدار کد تفصیلی فقط می تواند عدد صحیح باشد");
                           //'DetCode' Should Be Integer
                           Include(new NumberDateFilterReqValidator());
                       });
        }
        private bool ValidateDetCode(string detCode)
        {
            return int.TryParse(detCode, out int b);
        }
    }
}
