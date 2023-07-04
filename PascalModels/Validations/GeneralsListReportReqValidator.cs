using FluentValidation;
using PascalModels.Models;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class GeneralsListReportReqValidator : AbstractValidator<GeneralsListReportReq>
    {
        public GeneralsListReportReqValidator()
        {
            //بازه ی کد جنرال باید مشخص شود
            //با استفاده از بازه ی کد جنرال یک لیست بر  میگردد

            When(p =>
                       (!string.IsNullOrWhiteSpace(p.GeneralFrom) && !string.IsNullOrWhiteSpace(p.GeneralTo)),
                       () =>
                       {
                           RuleFor(x => x.GeneralFrom).NotEmpty().WithMessage("از کل' نمی تواند خالی باشد'")
                                                      .MaximumLength(6).WithMessage("بیش از 6 کاراکتر مجاز نمی باشد")
                                                      .Must(ValidateCode).WithMessage("مقدار 'از کل' فقط می تواند عدد صحیح باشد")
                                                      .LessThanOrEqualTo(x => x.GeneralTo).WithMessage("بازه ی انتخابی صحیح نمی باشد."); //the selected range is incorrect.;
                           
                           RuleFor(x => x.GeneralTo).NotEmpty().WithMessage("از کل' نمی تواند خالی باشد'")
                                                    .MaximumLength(6).WithMessage("بیش از 6 کاراکتر مجاز نمی باشد")
                                                    .Must(ValidateCode).WithMessage("مقدار 'از کل' فقط می تواند عدد صحیح باشد");
                           Include(new NumberDateFilterReqValidator());
                       }).Otherwise(() =>
                       {
                           RuleFor(x => x).NotEmpty().WithMessage("هر دو مقدار باید پر شوند"); //both must be filled('GeneralFrom' And 'GeneralTo').

                       });
        }

        private bool ValidateCode(string code)
        {
            return int.TryParse(code, out int _);
        }
    }
}
