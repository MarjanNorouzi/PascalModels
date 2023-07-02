using FluentValidation;
using PascalModels.Models;
using Personal_Information.Models.ProcModels;

namespace Personal_Information.Validators.SQLValidators
{
    public class GroupListReqValidator : AbstractValidator<GroupsListReportReq>
    {
        public GroupListReqValidator()
        {
            When(p =>
                       (p.GroupFrom is not null && p.GroupTo is not null),
                       () =>
                       {
                           RuleFor(x => x.GroupFrom).NotEmpty().MaximumLength(2).Must(ValidateGroupNum);
                           RuleFor(x => x.GroupTo).NotEmpty().MaximumLength(2).Must(ValidateGroupNum);
                       });
            When(p =>
                       (Convert.ToInt32(p.GroupFrom) < Convert.ToInt32(p.GroupTo)),
                       () =>
                       {
                           RuleFor(x => x).NotEmpty().WithMessage("the selected range is incorrect.");
                       });

            When(p =>
                       (string.IsNullOrWhiteSpace(p.GroupFrom) && string.IsNullOrWhiteSpace(p.GroupTo)),
                       () =>
                       {
                           RuleFor(x => x).NotEmpty().WithMessage("both must be filled('GroupFrom' And 'GroupTo').");
                       });

            When(p =>
                       !(string.IsNullOrEmpty(p.GroupKind.ToString())),
                       () =>
                       {
                           RuleFor(x => x.GroupKind).InclusiveBetween(1, 3);
                       });
        }
        private bool ValidateGroupNum(string generalCode)
        {
            return int.TryParse(generalCode, out int x);
        }
    }
}
