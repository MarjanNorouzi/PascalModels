using FluentValidation;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class DetailsListBySubCodeReqValidator : AbstractValidator<DetailsListBySubCodeReq>
    {
        //کد معین نمیتواند خالی باشد
        //با استفاده از  کد معین یک لیست از تفضیل با جمع بدهکار و بستانکار و مانده برمیگردد
        public DetailsListBySubCodeReqValidator()
        {
            Include(new NumberDateFilterReqValidator());
            RuleFor(x => x.SubCode).NotEmpty().NotNull().WithMessage("لطفا کد معین را وارد کنید")
                                   .Length(6, 6).WithMessage("بیش از 6 کاراکتر مجاز نمی باشد")
                                   .Must(ValidateSubCode).WithMessage("مقدار کد معین فقط می تواند عدد صحیح باشد");
        }
        private bool ValidateSubCode(string subCode)
        {
            return int.TryParse(subCode, out _);
        }
    }
}
