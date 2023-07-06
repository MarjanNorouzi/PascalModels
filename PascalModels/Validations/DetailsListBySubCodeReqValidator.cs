using FluentValidation;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class DetailsListBySubCodeReqValidator : AbstractValidator<DetailsListBySubCodeReq>
    {
        /// <summary>
        /// <para><em>اسم : لیست تفصیل</em></para> 
        /// <para>با استفاده از  کد معین یک لیست از تفصیل با جمع بدهکار و بستانکار و مانده برمیگردد</para> 
        /// <para>کد معین نمیتواند خالی باشد و همچنین باید شامل 6 رقم باشد</para> 
        /// <para>دارای فیلتر حساب های مانده دار نیز می باشدد</para> 
        /// </summary>
        public DetailsListBySubCodeReqValidator()
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
