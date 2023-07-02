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

            When(p =>
                     (p.FromDate is not null && p.ToDate is not null),
                     () =>
                     {
                         RuleFor(x => x.FromDate).Must(BeAvalidDate).WithMessage("Invalid date/time");
                     });


        }

        private bool BeAvalidDate(DateTimeOffset? fromDate)
        {
            //DateTimeOffset dt = DateTimeOffset.MinValue;
            DateTimeOffset.TryParse(fromDate.ToString(), out var dt);
            if (dt == DateTimeOffset.MinValue)
                return false;
            return true;
        }
    }

    public class NumberDateFilterReqValidator : AbstractValidator<NumberDateFilterReq>
    {
        public NumberDateFilterReqValidator()
        {
            var msg = "لطفا فقط یکی از موارد بازه تاریخ یا بازه شماره سند را مقداردهی کنید";
            When(p =>
                      !(
                        (p.NumFrom is not null && p.NumTo is not null)
                        &&
                        (p.FromDate is not null && p.ToDate is not null)
                       ),
                      () =>
                      {
                          RuleFor(x => x).NotEmpty().WithMessage(msg);

                      }).Otherwise(
                      () =>
                      {
                          When(p =>
                                    !(
                                      (p.NumFrom is null && p.NumTo is null)
                                      ||
                                      (p.NumFrom is not null && p.NumTo is not null)
                                     ),
                                    () =>
                                    {
                                        //RuleFor(x => x).NotEmpty().WithMessage("both must be filled('FromNum' And 'ToNum').");
                                        RuleFor(x => x).NotEmpty().WithMessage(msg);

                                    }).Otherwise(
                                    () =>
                                    {
                                        When(p =>
                                                 !(
                                                   (p.FromDate is null && p.ToDate is null)
                                                   ||
                                                   (p.FromDate is not null && p.ToDate is not null)
                                                  ),
                                                 () =>
                                                 {
                                                     RuleFor(x => x).NotEmpty().WithMessage(msg);
                                                 });
                                    });
                      });
            When(p =>
                      (p.NumFrom < p.NumTo),
                      () =>
                      {
                          RuleFor(x => x).NotEmpty().WithMessage("the selected range is incorrect.");
                      });
            Include(new FromDateToDateReqValidator());
        }
    }
}
