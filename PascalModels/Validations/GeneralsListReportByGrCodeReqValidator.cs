using FluentValidation;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class GeneralsListReportByGrCodeReqValidator : AbstractValidator<GeneralsListReportByGrCodeReq>
    {
        public GeneralsListReportByGrCodeReqValidator()
        {
            RuleFor(x => x.GrCode).NotEmpty().NotNull().WithMessage("لطفا کد گروه را وارد کنید")
                .MaximumLength(2).WithMessage("بیش از 2 کاراکتر مجاز نمی باشد")
                .Must(ValidateGrCode).WithMessage("مقدار کد گروه فقط می تواند عدد صحیح باشد"); 
            Include(new NumberDateFilterReqValidator());
            
        }
        private bool ValidateGrCode(string grCode)
        {
            return int.TryParse(grCode, out int b);
        }
    }
}
