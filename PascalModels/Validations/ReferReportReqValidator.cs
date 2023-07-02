using FluentValidation;
using Personal_Information.Models.ProcModels;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class ReferReportReqValidator : AbstractValidator<ReferReportReq>
    {
        public ReferReportReqValidator()
        {
            When(p =>
                       (!(!string.IsNullOrWhiteSpace(p.DetCode) && !string.IsNullOrWhiteSpace(p.SubCode))),
                       () =>
                       {
                           RuleFor(x => x).NotEmpty().WithMessage("هر دو مقدار کد معین و تفصیل باید وارد شوند"); //Both 'DetCode' And 'SubCode' should be filled
                       });

            When(p =>
                       (!string.IsNullOrWhiteSpace(p.DetCode) && !string.IsNullOrWhiteSpace(p.SubCode)),
                       () =>
                       {
                           RuleFor(x => x.DetCode).MaximumLength(8).Must(ValidateCode).WithMessage("مقدار کد تفصیلی فقط می تواند عدد صحیح باشد"); //'DetCode' Should Be Integer
                           RuleFor(x => x.SubCode).MaximumLength(10).Must(ValidateCode).WithMessage("مقدار کد معین فقط می تواند عدد صحیح باشد"); //'SubCode' Should Be Integer
                           RuleFor(x => x.Refer).MaximumLength(10);
                           Include(new NumberDateFilterReqValidator());
                       });

        }
        private bool ValidateCode(string code)
        {
            return int.TryParse(code, out int b);
        }
    }
}