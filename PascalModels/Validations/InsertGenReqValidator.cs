using FluentValidation;
using PascalModels.Models;

namespace PascalModels.Validations
{
    public class InsertGenReqValidator : AbstractValidator<InsertGenReq>
    {
        public InsertGenReqValidator()
        {
            RuleFor(x => x.GroupCode).NotEmpty().NotNull().WithMessage("لطفا کد گروه را وارد کنید")
                                     .MaximumLength(2).WithMessage("بیش از 2 کاراکتر مجاز نمی باشد")
                                     .Must(ValidateCode).WithMessage("مقدار کد گروه فقط می تواند عدد صحیح باشد");


            RuleFor(x => x.GenCode).NotEmpty().NotNull().WithMessage("لطفا کد کل را وارد کنید")
                                   .MaximumLength(6).WithMessage("بیش از 6 کاراکتر مجاز نمی باشد")
                                   .Must(ValidateCode).WithMessage("مقدار کد کل فقط می تواند عدد صحیح باشد");

            RuleFor(x => x.GenName).NotEmpty().NotNull().WithMessage("لطفا نام کل را وارد کنید")
                                   .MaximumLength(50).WithMessage("بیش از 50 کاراکتر مجاز نمی باشد");
        }

        private bool ValidateCode(string Code)
        {
            return int.TryParse(Code, out int _);
        }
    }
}
