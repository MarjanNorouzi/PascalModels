using FluentValidation;
using PascalModels.Models;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class SubListReportByGenCodeReqValidator : AbstractValidator<SubListReportByGenCodeReq>
    {
        public SubListReportByGenCodeReqValidator()
        {
            //کد کل نمیتواند خالی باشد، با استفاده از کد کل یک لیستی بر اساس کد معین بر  میگردد
            When(p =>
                       (string.IsNullOrWhiteSpace(p.GeneralCode)),
                       () =>
                       {
                           RuleFor(x => x).NotEmpty().WithMessage("کد کل را وارد کنید"); //Insert 'GeneralCode'.
                       }).Otherwise(() =>
                       {
                           RuleFor(x => x.GeneralCode).MaximumLength(6).WithMessage("بیش از 6 کاراکتر مجاز نمی باشد")
                                                      .Must(ValidateGenCode).WithMessage("مقدار کد کل فقط می تواند عدد صحیح باشد"); //General Code Can Be Integer
                           Include(new NumberDateFilterReqValidator());
                       });
        }
        private bool ValidateGenCode(string generalCode)
        {
            return int.TryParse(generalCode, out int _);
        }
    }
}
