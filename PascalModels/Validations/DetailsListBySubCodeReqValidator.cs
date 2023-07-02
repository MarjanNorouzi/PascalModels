using FluentValidation;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class DetailsListBySubCodeReqValidator : AbstractValidator<DetailsListBySubCodeReq>
    {
        public DetailsListBySubCodeReqValidator()
        {
            When(p =>
                    (string.IsNullOrWhiteSpace(p.SubCode)),
                    () =>
                    {
                        RuleFor(x => x.SubCode).NotEmpty().NotNull().NotNull().WithMessage("لطفا کد معین را وارد کنید");
                    }).Otherwise(
                                 () =>
                                 {
                                     Include(new NumberDateFilterReqValidator());
                                     RuleFor(x => x.SubCode).MaximumLength(10);
                                 });
        }
    }
}
