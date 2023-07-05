using FluentValidation;
using PascalModels.Models;

namespace PascalModels.Validations
{
    public class InsertSubDbReqValidator : AbstractValidator<InsertSubDbReq>
    {
        //افزودن معین 
        //همه موارد(کد کل شامل 4 رقم)و(کد معین شامل 6 رقم)و(نام معین که شامل کاراکتر میباشد)و(نوع تفصیل) باید مقداردهی شوند
        public InsertSubDbReqValidator()
        {
            RuleFor(x => x.GenCode).NotEmpty().NotNull().WithMessage("لطفا نام کل را وارد کنید")
                .Length(4, 4).WithMessage("کد کل' باید 4 رقم باشد'")
                .Must(ValidateCode).WithMessage("مقدار کد کل فقط می تواند شامل اعداد باشد");

            RuleFor(x => x.SubCode).NotEmpty().NotNull().WithMessage("لطفا کد معین را وارد کنید")
                .Length(6, 6).WithMessage("کد معین' باید 6 رقم باشد'")
                .Must(ValidateCode).WithMessage("مقدار کد معین فقط می تواند شامل اعداد باشد");

            RuleFor(x => x.SubName).NotEmpty().NotNull().WithMessage("لطفا نام معین را وارد کنید")
                .MaximumLength(50).WithMessage("بیش از 50 کاراکتر مجاز نمی باشد");

            RuleFor(x => x.DetKind).NotEmpty().NotNull().WithMessage("لطفا نوع تفصیل را وارد کنید");
        }
        private bool ValidateCode(string Code)
        {
            return int.TryParse(Code, out _);
        }
    }
}
