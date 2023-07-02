using FluentValidation;
using PascalModels.Models;

namespace PascalModels.Validations
{
    public class GeneralsListReportReqValidator : AbstractValidator<GeneralsListReportReq>
    {
        public GeneralsListReportReqValidator()
        {
            When(p =>
                       (Convert.ToInt32(p.GeneralFrom) > Convert.ToInt32(p.GeneralTo)),
                       () =>
                       {
                           RuleFor(x => x).NotEmpty().WithMessage("بازه ی انتخابی صحیح نمی باشد."); //the selected range is incorrect.
                       });

            When(p =>
                       (string.IsNullOrWhiteSpace(p.GeneralFrom) && string.IsNullOrWhiteSpace(p.GeneralTo)),
                       () =>
                       {
                           RuleFor(x => x).NotEmpty().WithMessage("هر دو مقدار باید پر شوند"); //both must be filled('GeneralFrom' And 'GeneralTo').
                       });

            When(p =>
                       ((!string.IsNullOrWhiteSpace(p.GeneralFrom) && !string.IsNullOrWhiteSpace(p.GeneralTo))
                       && (Convert.ToInt32(p.GeneralFrom) < Convert.ToInt32(p.GeneralTo))),
                       () =>
                       {
                           RuleFor(x => x.GeneralFrom).NotEmpty().MaximumLength(6);
                           RuleFor(x => x.GeneralTo).NotEmpty().MaximumLength(6);
                           //check new name
                           //Include(new FromSanadNoToNoReqValidator());
                       });
        }
    }
}
