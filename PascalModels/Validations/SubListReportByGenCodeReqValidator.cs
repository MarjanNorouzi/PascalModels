using FluentValidation;
using PascalModels.Models;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class SubListReportByGenCodeReqValidator : AbstractValidator<SubListReportByGenCodeReq>
    {
        public SubListReportByGenCodeReqValidator()
        {
            When(p =>
                       (string.IsNullOrWhiteSpace(p.GeneralCode)),
                       () =>
                       {
                           RuleFor(x => x).NotEmpty().WithMessage("کد کل را وارد کنید"); //Insert 'GeneralCode'.
                       });

            When(p =>
                       (!string.IsNullOrWhiteSpace(p.GeneralCode)),
                       () =>
                       {
                           RuleFor(x => x.GeneralCode).MaximumLength(6).Must(ValidateGenCode).WithMessage("مقدار کد کل فقط می تواند عدد صحیح باشد");
                           //General Code Can Be Integer
                           Include(new NumberDateFilterReqValidator());
                       });
        }
        private bool ValidateGenCode(string generalCode)
        {
            return int.TryParse(generalCode, out int b);
        }
    }
}
