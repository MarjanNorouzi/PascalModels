using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalModels.Validations
{
    public class InsertToSubDbReqValidator : AbstractValidator<InsertToSubDbReq>
    {
        public InsertToSubDbReqValidator()
        {
            RuleFor(x => x.GenCode).NotEmpty().NotNull().WithMessage("لطفا نام کل را وارد کنید").MaximumLength(6).WithMessage("بیش از 6 کاراکتر مجاز نمی باشد");
            RuleFor(x => x.SubCode).NotEmpty().NotNull().WithMessage("لطفا کد معین را وارد کنید").MaximumLength(10).WithMessage("بیش از 10 کاراکتر مجاز نمی باشد");
            RuleFor(x => x.SubName).NotEmpty().NotNull().WithMessage("لطفا نام معین را وارد کنید").MaximumLength(50).WithMessage("بیش از 50 کاراکتر مجاز نمی باشد");
            RuleFor(x => x.DetKind).NotEmpty().NotNull().WithMessage("لطفا نوع تفضیل را وارد کنید");
        }
    }
}
