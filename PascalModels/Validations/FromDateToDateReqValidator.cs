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
}
