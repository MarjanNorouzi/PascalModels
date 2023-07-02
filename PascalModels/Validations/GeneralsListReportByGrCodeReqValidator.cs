using FluentValidation;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class GeneralsListReportByGrCodeReqValidator : AbstractValidator<GeneralsListReportByGrCodeReq>
    {
        public GeneralsListReportByGrCodeReqValidator()
        {
            When(p =>
                       (string.IsNullOrWhiteSpace(p.GrCode)),
                       () =>
                       {
                           RuleFor(x => x.GrCode).NotEmpty().NotNull().WithMessage("لطفا کد گروه را وارد کنید");
                       }).Otherwise(
                                    () =>
                                    {
                                        Include(new NumberDateFilterReqValidator());
                                        RuleFor(x => x.GrCode).MaximumLength(2);
                                    });

        }
    }
}
