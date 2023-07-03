using FluentValidation;
using PascalModels.Models;

namespace PascalModels.Validations
{
    public class InsertSubDbReqValidator : AbstractValidator<InsertSubDbReq>
    {
        //همه موارد باید مقداردهی شوند
        public InsertSubDbReqValidator()
        {
            RuleFor(x => x.GenCode).NotEmpty().NotNull().WithMessage("لطفا نام کل را وارد کنید")
                                   .MaximumLength(6).WithMessage("بیش از 6 کاراکتر مجاز نمی باشد")
                                   .Must(ValidateCode).WithMessage("مقدار کد کل فقط می تواند عدد صحیح باشد");

            RuleFor(x => x.SubCode).NotEmpty().NotNull().WithMessage("لطفا کد معین را وارد کنید")
                                   .MaximumLength(10).WithMessage("بیش از 10 کاراکتر مجاز نمی باشد")
                                   .Must(ValidateCode).WithMessage("مقدار کد معین فقط می تواند عدد صحیح باشد");

            RuleFor(x => x.SubName).NotEmpty().NotNull().WithMessage("لطفا نام معین را وارد کنید")
                                   .MaximumLength(50).WithMessage("بیش از 50 کاراکتر مجاز نمی باشد");

            RuleFor(x => x.DetKind).NotEmpty().NotNull().WithMessage("لطفا نوع تفضیل را وارد کنید");
        }
        private bool ValidateCode(string Code)
        {
            return int.TryParse(Code, out int b);
        }
    }
}
