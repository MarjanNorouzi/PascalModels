using FluentValidation;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class DetailsListBySubCodeReqValidator : AbstractValidator<DetailsListBySubCodeReq>
    {
        public DetailsListBySubCodeReqValidator()
        {
            Include(new NumberDateFilterReqValidator());
            RuleFor(x => x.SubCode).NotEmpty().NotNull().WithMessage("لطفا کد معین را وارد کنید")
                .MaximumLength(10).WithMessage("بیش از 10 کاراکتر مجاز نمی باشد")
                .Must(ValidateSubCode).WithMessage("مقدار کد معین فقط می تواند عدد صحیح باشد");
        }
        private bool ValidateSubCode(string subCode)
        {
            return int.TryParse(subCode, out int b);
        }
    }
}
