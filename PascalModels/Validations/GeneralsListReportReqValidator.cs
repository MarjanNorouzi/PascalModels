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

            //to do : check if the Convert proccess was wrong, doesnt throw Exception
            When(p =>
                       (Convert.ToInt32(p.GeneralFrom) > Convert.ToInt32(p.GeneralTo)),
                       () =>
                       {
                           RuleFor(x => x).NotEmpty().WithMessage("بازه ی انتخابی صحیح نمی باشد."); //the selected range is incorrect.
                       });

            When(p =>
                       (string.IsNullOrWhiteSpace(p.GeneralFrom) || string.IsNullOrWhiteSpace(p.GeneralTo)),
                       () =>
                       {
                           RuleFor(x => x).NotEmpty().WithMessage("هر دو مقدار باید پر شوند"); //both must be filled('GeneralFrom' And 'GeneralTo').
                       });

            When(p =>
                       (!string.IsNullOrWhiteSpace(p.GeneralFrom) && !string.IsNullOrWhiteSpace(p.GeneralTo))
                       && (Convert.ToInt32(p.GeneralFrom) < Convert.ToInt32(p.GeneralTo)),
                       () =>
                       {
                           RuleFor(x => x.GeneralFrom).NotEmpty().WithMessage("از کل' نمی تواند خالی باشد'")
                                                      .MaximumLength(6).WithMessage("بیش از 6 کاراکتر مجاز نمی باشد");
                           RuleFor(x => x.GeneralTo).NotEmpty().WithMessage("از کل' نمی تواند خالی باشد'") 
                                                    .MaximumLength(6).WithMessage("بیش از 6 کاراکتر مجاز نمی باشد");
                           Include(new NumberDateFilterReqValidator());
                       });
        }
    }
}
