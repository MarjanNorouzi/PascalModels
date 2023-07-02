using FluentValidation;
using PascalModels.Models.BaseModels;

namespace PascalModels.Validations
{
    public class TotalDebitCreditSumValidator : AbstractValidator<TotalDebitCreditSum>
    {
        public TotalDebitCreditSumValidator()
        {
            When(p =>
                       (!(string.IsNullOrWhiteSpace(p.TotalSumOfDebit.ToString()) || string.IsNullOrWhiteSpace(p.TotalSumOfCredit.ToString()))),
                       () =>
                       {
                           RuleFor(x => x.TotalSumOfDebit).NotEmpty();
                           RuleFor(x => x.TotalSumOfCredit).NotEmpty();
                       });
        }
    }

    public class TotalRemainedValidator : AbstractValidator<TotalDebitCreditSum>
    {
        public TotalRemainedValidator()
        {
            When(p =>
                       (!(string.IsNullOrWhiteSpace(p.TotalSumOfDebit.ToString()) || string.IsNullOrWhiteSpace(p.TotalSumOfCredit.ToString()))),
                       () =>
                       {
                           RuleFor(x => x.TotalSumOfDebit).NotEmpty();
                           RuleFor(x => x.TotalSumOfCredit).NotEmpty();
                           Include(new TotalDebitCreditSumValidator());
                       });
        }
    }

    public class TotalDebitCreditValidator : AbstractValidator<TotalDebitCredit>
    {
        public TotalDebitCreditValidator()
        {
            When(p =>
                       (!(string.IsNullOrWhiteSpace(p.TotalDebit.ToString()) || string.IsNullOrWhiteSpace(p.TotalCredit.ToString()))),
                       () =>
                       {
                           RuleFor(x => x.TotalDebit).NotEmpty();
                           RuleFor(x => x.TotalCredit).NotEmpty();
                       });
        }
    }
}
