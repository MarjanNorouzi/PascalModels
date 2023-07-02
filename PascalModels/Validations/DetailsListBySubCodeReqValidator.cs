using FluentValidation;
using Personal_Information.Validators.SQLValidators;

namespace PascalModels.Validations
{
    public class DetailsListBySubCodeReqValidator : AbstractValidator<DetailsListBySubCodeReq>
    {
        public DetailsListBySubCodeReqValidator()
        {
            Include(new NumberDateFilterReqValidator());
            RuleFor(x => x.SubCode).NotEmpty().NotNull().WithMessage("لطفا کد معین را وارد کنید");
            RuleFor(x => x.SubCode).MaximumLength(10);
        }
    }
}
