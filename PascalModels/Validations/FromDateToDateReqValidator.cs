using FluentValidation;
using PascalModels.Models.BaseModels;



namespace Personal_Information.Validators.SQLValidators
{
    public class FromDateToDateReqValidator : AbstractValidator<FromDateToDateReq>
    {
        public FromDateToDateReqValidator()
        {
            When(p =>
                      (string.IsNullOrWhiteSpace(p.FromDate.ToString()) || string.IsNullOrWhiteSpace(p.ToDate.ToString())),
                      () =>
                      {
                          RuleFor(x => x).NotEmpty().WithMessage("both must be filled('FromDate' And 'ToDate').");
                      });

            When(p =>
                      (p.FromDate < p.ToDate),
                      () =>
                      {
                          RuleFor(x => x).NotEmpty().WithMessage("the selected range is incorrect.");
                      });

            RuleFor(x => x.FromDate).Must(BeAValidDate).WithMessage("Invalid date/time");
        }

        private bool BeAValidDate(DateTimeOffset fromDate)
        {
            DateTimeOffset dt = DateTimeOffset.MinValue;
            DateTimeOffset.TryParse(fromDate.ToString(), out dt);
            if(dt ==  DateTimeOffset.MinValue)
                return false;
            return true;
        }
    }

    public class FromSanadNoToNoReqValidator : AbstractValidator<NumberDateFilterReq>
    {
        public FromSanadNoToNoReqValidator()
        {
            //TODO
            When(p =>
                      (
                      (!(string.IsNullOrWhiteSpace(p.NumFrom.ToString()) && string.IsNullOrWhiteSpace(p.NumTo.ToString()))
                      && !(string.IsNullOrWhiteSpace(p.FromDate.ToString()) || string.IsNullOrWhiteSpace(p.ToDate.ToString())))
                      ||
                      (!(string.IsNullOrWhiteSpace(p.FromDate.ToString()) && string.IsNullOrWhiteSpace(p.ToDate.ToString())))
                      && !(string.IsNullOrWhiteSpace(p.NumFrom.ToString()) || string.IsNullOrWhiteSpace(p.NumTo.ToString()))
                      ),
                      () =>
                      {
                          RuleFor(x => x).NotEmpty().WithMessage("only one of the fields must be filled");
                      });

            When(p =>
                      (string.IsNullOrWhiteSpace(p.NumFrom.ToString()) || string.IsNullOrWhiteSpace(p.NumTo.ToString())),
                      () =>
                      {
                          RuleFor(x => x).NotEmpty().WithMessage("both must be filled('FromNum' And 'ToNum').");
                      });

            When(p =>
                      (p.NumFrom < p.NumTo),
                      () =>
                      {
                          RuleFor(x => x).NotEmpty().WithMessage("the selected range is incorrect.");
                      });
            //When(p =>
            //         (!(string.IsNullOrWhiteSpace(p.NumFrom.ToString()) && string.IsNullOrWhiteSpace(p.NumTo.ToString()))
            //         && ),
            //         () =>
            //         {
            //             RuleFor(x => x).NotEmpty().WithMessage("the selected range is incorrect.");
            //         });

        }
    }
}
