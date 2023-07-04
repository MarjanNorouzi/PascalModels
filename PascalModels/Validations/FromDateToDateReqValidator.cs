using FluentValidation;
using PascalModels.Models.BaseModels;
using PascalModels.Validations;

namespace Personal_Information.Validators.SQLValidators
{
    public class FromDateToDateReqValidator : AbstractValidator<FromDateToDateReq>
    {
        public FromDateToDateReqValidator()
        {
            //فرمت تاریخ درست باشد
            //هردو فیلد بازه مقداردهی شده باشد

            When(p =>
                     (p.FromDate is not null && p.ToDate is not null),
                     () =>
                     {
                         RuleFor(x => x.FromDate).Must(BeAvalidDate).WithMessage("Invalid date/time");
                         RuleFor(x => x.ToDate).Must(BeAvalidDate).WithMessage("Invalid date/time");
                     }).Otherwise(
                        () =>
                        {
                            RuleFor(x => x).NotEmpty().WithMessage("هر دو فیلد بازه تاریخ باید مشخص شود");
                        });
            When(p =>
                      (p.FromDate is not null && p.ToDate is not null && p.FromDate < p.ToDate),
                      () =>
                      {
                          RuleFor(x => x).NotEmpty().WithMessage("بازه وارد شده صحیح نمی باشد");
                      });
        }

        private bool BeAvalidDate(DateTimeOffset? fromDate)
        {
            DateTimeOffset.TryParse(fromDate.ToString(), out var dt);
            if (dt == DateTimeOffset.MinValue)
                return false;
            return true;
        }
    }

    public class NumberDateFilterReqValidator : AbstractValidator<NumberDateFilterReq>
    {
        //فقط یکی از بازه های تاریخ و یا شماره سند مقداردهی شده باشد

        public NumberDateFilterReqValidator()
        {
            var msg = "لطفا فقط یکی از موارد بازه تاریخ یا بازه شماره سند را مقداردهی کنید";
            //"both must be filled('FromNum' And 'ToNum')or('FromDate' And 'ToDate')."
            When(p =>
                    p.NumFrom is not null && p.NumTo is not null
                    &&
                    p.FromDate is not null && p.ToDate is not null,
                () =>
                {
                    RuleFor(x => x).NotEmpty().WithMessage(msg);
                }).Otherwise(
                    () =>
                    {
                        When(p => !(p.NumFrom.HasValue && p.NumTo.HasValue),
                        () =>
                        {
                            RuleFor(x => x).NotEmpty().WithMessage(msg);
                        }).Otherwise(
                        () =>
                        {
                            When(p => p.NumTo.HasValue && p.NumFrom.HasValue && p.NumFrom < p.NumTo,
                            () =>
                            {
                                RuleFor(x => x.NumFrom).GreaterThan(1).WithMessage("بازه وارد شده برای شماره سند صحیح نمی باشد")
                                    .LessThanOrEqualTo(x => x.NumTo).WithMessage("بازه وارد شده برای شماره سند صحیح نمی باشد");
                            }).Otherwise(() =>
                            {
                                Include(new FromDateToDateReqValidator());
                            });
                        });
                    });

            Include(new BaseModelValidator());
        }
    }
}

