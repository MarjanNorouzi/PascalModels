using FluentValidation;
using Personal_Information.Models.ProcModels;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class TurnoverBySubCodeReqValidator : AbstractValidator<TurnoverBySubCodeReq>
    {
        //گردش حساب
        //کد معین نمیتواند خالی باشد
        //فقط یکی از بازه های شماره سند و یا تاریخ باید مشخص شود

        public TurnoverBySubCodeReqValidator()
        {
            Include(new NumberDateFilterReqValidator());
            RuleFor(x => x.SubCode).NotEmpty().NotNull().WithMessage("لطفا کد معین را وارد کنید")
                .Length(6, 6).WithMessage("کد معین' باید 6 رقم باشد'")
                .Must(ValidateSubCode).WithMessage("مقدار کد معین فقط می تواند شامل اعداد باشد");
        }
        private bool ValidateSubCode(string subCode)
        {
            return int.TryParse(subCode, out _);
        }
    }
}
