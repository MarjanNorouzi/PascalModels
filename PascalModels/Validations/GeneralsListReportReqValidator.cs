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

            RuleFor(x => x.GeneralFrom).NotEmpty().WithMessage("از کل' نمی تواند خالی باشد'")
                .Length(4, 4).WithMessage("کد کل' باید 4 رقم باشد'")
                .Must(ValidateCode).WithMessage("مقدار 'از کل' فقط می تواند شامل اعداد باشد")
                .LessThan(x => x.GeneralTo).WithMessage("شروع بازه 'کل' نمی تواند از پایان آن بزرگتر باشد"); //the selected range is incorrect.;

            RuleFor(x => x.GeneralTo)
                .NotEmpty().WithMessage("تا کل' نمی تواند خالی باشد'")
                .Length(4, 4).WithMessage("کد کل' باید 4 رقم باشد'")
                .Must(ValidateCode).WithMessage("مقدار 'تا کل' فقط می تواند شامل اعداد باشد");

            Include(new NumberDateFilterReqValidator());
        }

        private bool ValidateCode(string code)
        {
            return int.TryParse(code, out _);
        }
    }
}
