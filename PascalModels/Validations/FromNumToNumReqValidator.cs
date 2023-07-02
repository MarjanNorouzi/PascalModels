using FluentValidation;

namespace Personal_Information.Validators.SQLValidators
{
    public class FromNumToNumReqValidator : AbstractValidator<FromNumToNumReq>
    {
        public FromNumToNumReqValidator()
        {
            When(p =>
                      (!(string.IsNullOrWhiteSpace(p.FromNum.ToString()) && string.IsNullOrWhiteSpace(p.ToNum.ToString()))
                      && !(string.IsNullOrWhiteSpace(p.FromDate.ToString()) || string.IsNullOrWhiteSpace(p.ToDate.ToString()))),
                      () =>
                      {
                          RuleFor(x => x).NotEmpty().WithMessage("only one of the fields must be filled");
                      });

            When(p =>
                      (!(string.IsNullOrWhiteSpace(p.FromDate.ToString()) && string.IsNullOrWhiteSpace(p.ToDate.ToString())))
                      && !(string.IsNullOrWhiteSpace(p.FromNum.ToString()) || string.IsNullOrWhiteSpace(p.ToNum.ToString())),
                      () =>
                      {
                          RuleFor(x => x).NotEmpty().WithMessage("only one of the fields must be filled");
                      });

            When(p =>
                      (string.IsNullOrWhiteSpace(p.FromNum.ToString()) || string.IsNullOrWhiteSpace(p.ToNum.ToString())),
                      () =>
                      {
                          RuleFor(x => x).NotEmpty().WithMessage("both must be filled('FromNum' And 'ToNum').");
                      });

            When(p =>
                      (p.FromNum == null || p.ToNum == null ),
                      () =>
                      {
                          RuleFor(x => x).NotEmpty().WithMessage("both must be filled('FromNum' And 'ToNum').");
                      });

            When(p =>
                      (p.FromNum < p.ToNum),
                      () =>
                      {
                          RuleFor(x => x).NotEmpty().WithMessage("the selected range is incorrect.");
                      });

            
        }
    }
}
