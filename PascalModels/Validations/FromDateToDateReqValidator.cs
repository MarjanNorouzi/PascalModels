using FluentValidation;
using PascalModels.Models.BaseModels;
using PascalModels.Validations;

namespace Personal_Information.Validators.SQLValidators
{
    public class FromDateToDateReqValidator : AbstractValidator<FromDateToDateReq>
    {
        public FromDateToDateReqValidator()
        {
            /// <summary>
            /// <para><em>اسم : محدوده تاریخ</em></para> 
            /// <para>فرمت تاریخ درست باشد</para> 
            /// <para>شروع بازه از پایان آن نمیتواند بزرگتر باشد</para> 
            /// <para>هردو فیلد بازه باید مقداردهی شود</para> 
            /// </summary>

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
                          RuleFor(x => x).NotEmpty().WithMessage("شروع بازه 'تاریخ' نمی تواند از پایان آن بزرگتر باشد");
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
        /// <summary>
        /// <para><em>اسم : محدوده شماره سند</em></para> 
        /// <para>فقط  باید یکی از بازه های تاریخ و یا شماره سند مقداردهی شود</para> 
        /// <para>شروع بازه از پایان آن نمیتواند بزرگتر باشد</para> 
        /// <para>هردو فیلد بازه باید مقداردهی شود</para> 
        /// </summary>

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
                    RuleFor(x => x).Empty().WithMessage(msg);
                }).Otherwise(
                    () =>
                    {
                        When(p => !(p.NumFrom.HasValue && p.NumTo.HasValue),
                        () =>
                        {
                            RuleFor(x => x).Empty().WithMessage(msg);
                        }).Otherwise(
                        () =>
                        {
                            When(p => p.NumTo.HasValue && p.NumFrom.HasValue && p.NumFrom < p.NumTo,
                            () =>
                            {
                                RuleFor(x => x.NumFrom).GreaterThan(1).WithMessage("شروع بازه 'شماره سند' نمی تواند از پایان آن بزرگتر باشد")
                                    .LessThanOrEqualTo(x => x.NumTo).WithMessage("شروع بازه 'شماره سند' نمی تواند از پایان آن بزرگتر باشد");
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

