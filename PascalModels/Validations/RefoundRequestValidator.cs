using FluentValidation;
using PascalModels.Models.BaseModels;
using System.Globalization;
using System.Text.RegularExpressions;

namespace PersonalInformation.Validation
{
    public class DateFilterValidator : AbstractValidator<FromDateToDateReq>
    {
        public DateFilterValidator()
        {
        //    When(p =>
        //               (string.IsNullOrWhiteSpace(p.SellDate) || string.IsNullOrWhiteSpace(p.Refer))
        //               && string.IsNullOrWhiteSpace(p.FlightId),
        //               () =>
        //               {
        //                   RuleFor(x => x.FlightId).NotEmpty().WithMessage("One is required ('SellDate' And 'Refer', 'FlightId').");
        //               });

        //    When(p =>
        //               ((!string.IsNullOrWhiteSpace(p.SellDate) || !string.IsNullOrWhiteSpace(p.Refer))
        //               && !string.IsNullOrWhiteSpace(p.FlightId)
        //               ),
        //               () =>
        //               {
        //                   RuleFor(x => x.FlightId).Empty().WithMessage("One is required ('SellDate' And 'Refer', 'FlightId').");
        //               });

        //    When(p =>
        //              (string.IsNullOrWhiteSpace(p.FlightId)
        //              && (!string.IsNullOrWhiteSpace(p.SellDate) && !string.IsNullOrWhiteSpace(p.Refer))
        //              ), () =>
        //              {
        //                  RuleFor(x => x.Refer).Length(6).Must(Validate_Refer).WithMessage("'Refer' characters is not valid").When(x => !string.IsNullOrWhiteSpace(x.Refer));
        //                  RuleFor(x => x.SellDate).Length(10).Must(Validate_SellDate).WithMessage("'Sell Date' format is not valid").When(x => !string.IsNullOrWhiteSpace(x.SellDate));
        //              });

        //    When(p =>
        //              ((string.IsNullOrWhiteSpace(p.SellDate) && string.IsNullOrWhiteSpace(p.Refer))
        //                && !string.IsNullOrWhiteSpace(p.FlightId)
        //              ),
        //              () =>
        //              {
        //                  RuleFor(x => x.FlightId).Length(32);
        //              });

        //    RuleFor(x => x.Remark)
        //        .MaximumLength(15);
        //}

        //private bool Validate_Refer(string refer)
        //{
        //    if (!Regex.IsMatch(refer, @"^[A-Z0-9]+$"))
        //        return false;

        //    else
        //        return true;
        //}

        //private bool Validate_SellDate(string sellDate)
        //{
        //    DateTime.TryParseExact(sellDate,
        //                           "yyyy/MM/dd",
        //                           new CultureInfo("fa-Ir"),
        //                           DateTimeStyles.None,
        //                           out var dt);

        //    if (dt == DateTime.MinValue)
        //    {
        //        return false;
        //    }

        //    return true;
        }
    }
}
