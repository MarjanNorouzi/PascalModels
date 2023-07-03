using FluentValidation;
using PascalModels.Models;

namespace PascalModels.Validations
{
    public class InsertToGrDbReqValidator : AbstractValidator<InsertToGrDbReq>
    {
        public InsertToGrDbReqValidator()
        {
            RuleFor(x => x.GrCode).NotEmpty().NotNull().WithMessage("لطفا کد گروه را وارد کنید").MaximumLength(2).WithMessage("بیش از 2 کاراکتر مجاز نمی باشد");
            RuleFor(x => x.GrName).NotEmpty().NotNull().WithMessage("لطفا نام گروه را وارد کنید").MaximumLength(50).WithMessage("بیش از 50 کاراکتر مجاز نمی باشد");
            RuleFor(x => x.Grkind).NotEmpty().NotNull().WithMessage("لطفا نوع گروه را وارد کنید");
        }
    }
}
