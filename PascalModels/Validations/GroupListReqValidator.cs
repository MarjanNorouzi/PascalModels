using FluentValidation;
using PascalModels.Models;

namespace Personal_Information.Validators.SQLValidators
{
    public class GroupListReqValidator : AbstractValidator<GroupsListReportReq>
    {
        //فقط یکی از بازه های شماره سند و یا تاریخ باید مشخص شود
        //بازه کد گزوه باید مشخص شود
        //گزارش گروه ها
        public GroupListReqValidator()
        {
            When(p =>
                       (p.GroupFrom is not null && p.GroupTo is not null),
                       () =>
                       {
                           RuleFor(x => x.GroupFrom).NotEmpty().MaximumLength(2).WithMessage("بیش از 2 کاراکتر مجاز نمی باشد")
                                                    .Must(ValidateGroupNum).WithMessage("مقدار کد گروه فقط می تواند عدد صحیح باشد");

                           RuleFor(x => x.GroupTo).NotEmpty().MaximumLength(2).WithMessage("بیش از 2 کاراکتر مجاز نمی باشد")
                                                  .Must(ValidateGroupNum).WithMessage("مقدار کد گروه فقط می تواند عدد صحیح باشد");
                       });
            When(p =>
                       (Convert.ToInt32(p.GroupFrom) < Convert.ToInt32(p.GroupTo)),
                       () =>
                       {
                           RuleFor(x => x).NotEmpty().WithMessage("بازه وارد شده صحیح نمی باشد"); //"the selected range is incorrect."
                       });

            When(p =>
                       (string.IsNullOrWhiteSpace(p.GroupFrom) && string.IsNullOrWhiteSpace(p.GroupTo)),
                       () =>
                       {
                           RuleFor(x => x).NotEmpty().WithMessage("هردو فیلد بازه باید مشخص شود"); //"both must be filled('GroupFrom' And 'GroupTo')."
                       });

            When(p =>
                       !(string.IsNullOrEmpty(p.GroupKind.ToString())),
                       () =>
                       {
                           RuleFor(x => x.GroupKind).InclusiveBetween(1, 3).WithMessage("خارج از بازه ی 1 تا 3 مجاز نمی باشد");
                       });
        }
        private bool ValidateGroupNum(string grCode)
        {
            return int.TryParse(grCode, out int x);
        }
    }
}
