using FluentValidation;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class GeneralsListReportByGrCodeReqValidator : AbstractValidator<GeneralsListReportByGrCodeReq>
    {
        //با استفاده از  کد گروه یک لیست از کل با جمع بدهکار و بستانکار و مانده برمیگردد
        //کد گروه نمیتواند خالی باشد
        public GeneralsListReportByGrCodeReqValidator()
        {
            RuleFor(x => x.GrCode).NotEmpty().NotNull().WithMessage("لطفا کد گروه را وارد کنید")
                                  .Length(2, 2).WithMessage("تعداد 2 کاراکتر مجاز می باشد")
                                  .Must(ValidateGrCode).WithMessage("مقدار کد گروه فقط می تواند شامل اعداد باشد");

            Include(new NumberDateFilterReqValidator());
        }
        private bool ValidateGrCode(string grCode)
        {
            return int.TryParse(grCode, out _);
        }
    }
}
