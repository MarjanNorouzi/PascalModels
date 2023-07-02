using FluentValidation;
using PascalModels.Models.BaseModels;

namespace PersonalInformation.Validation
{
    public class DebitCreditSumValidator : AbstractValidator<DebitCreditSum>
    {
        public DebitCreditSumValidator()
        {
            When(p =>
                       (!(string.IsNullOrWhiteSpace(p.SumOfDebit.ToString()) || string.IsNullOrWhiteSpace(p.SumOfCredit.ToString()))),
                       () =>
                       {
                           RuleFor(x => x.SumOfDebit).NotEmpty();
                           RuleFor(x => x.SumOfCredit).NotEmpty();
                       });
        }
    }
    public class RemainedValidator : AbstractValidator<Remained>
    {
        public RemainedValidator()
        {
            When(p =>
                       (p.RemainedDebit == 0 && p.RemainedCredit > 0) || (p.RemainedDebit > 0 && p.RemainedCredit == 0),
                       () =>
                       {
                           RuleFor(x => x.RemainedDebit).NotEmpty();
                           RuleFor(x => x.RemainedCredit).NotEmpty();
                       });
        }
    }
}
