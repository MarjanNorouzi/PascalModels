using FluentValidation;
using PascalModels.Models;

namespace PascalModels.Validations
{
    public class InsertDetReqValidator : AbstractValidator<InsertDetReq>
    {
        public InsertDetReqValidator()
        {
            RuleFor(x => x.DetCode).NotEmpty().NotNull().WithMessage("لطفا کد تفصیل را وارد کنید").MaximumLength(6).WithMessage("بیش از 8 کاراکتر مجاز نمی باشد");
            RuleFor(x => x.DetName).NotEmpty().NotNull().WithMessage("لطفا نام تفصیل را وارد کنید").MaximumLength(50).WithMessage("بیش از 50 کاراکتر مجاز نمی باشد");
        }
    }
}
