using FluentValidation;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class GeneralsListReportByGrCodeReqValidator : AbstractValidator<GeneralsListReportByGrCodeReq>
    {
        public GeneralsListReportByGrCodeReqValidator()
        {
            RuleFor(x => x.GrCode).NotEmpty().NotNull().WithMessage("لطفا کد گروه را وارد کنید");
            Include(new NumberDateFilterReqValidator());
            RuleFor(x => x.GrCode).MaximumLength(2);
        }
    }
}
