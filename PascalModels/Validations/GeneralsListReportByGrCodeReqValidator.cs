using FluentValidation;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class GeneralsListReportByGrCodeReqValidator : AbstractValidator<GeneralsListReportByGrCodeReq>
    {
        //لیست کل بر اساس گروه
        //با استفاده از  کد گروه یک لیست از کل با جمع بدهکار و بستانکار و مانده برمیگردد
        //کد گروه نمیتواند خالی باشد و همچنین باید شامل 2 رقم باشد
        //دارای فیلتر حساب های مانده دار نیز می باشد
        public GeneralsListReportByGrCodeReqValidator()
        {
            RuleFor(x => x.GrCode).NotEmpty().NotNull().WithMessage("لطفا کد گروه را وارد کنید")
                .Length(2, 2).WithMessage("کد گروه' باید 2 رقم باشد'")
                .Must(ValidateGrCode).WithMessage("مقدار کد گروه فقط می تواند شامل اعداد باشد");

            Include(new NumberDateFilterReqValidator());
        }
        private bool ValidateGrCode(string grCode)
        {
            return int.TryParse(grCode, out _);
        }
    }
}
