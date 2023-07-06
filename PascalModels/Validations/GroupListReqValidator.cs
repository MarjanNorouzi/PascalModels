using FluentValidation;
using PascalModels.Models;

namespace Personal_Information.Validators.SQLValidators
{
    public class GroupListReqValidator : AbstractValidator<GroupsListReportReq>
    {
        /// <summary>
        /// <para><em>گزارش گروه ها</em></para>
        /// <para>فقط یکی از بازه های شماره سند و یا تاریخ باید مشخص شود</para> 
        /// <para>بازه ی کد گروه باید مشخص شود</para> 
        /// <para>کدهای مقداردهی شده در بازه ی گروه باید شامل دو رقم باشد</para> 
        /// <para>نوع گروه خارج از بازه ی 1 تا 3 مجاز نمی باشد</para> 
        /// <para>دارای فیلتر حساب های مانده دار نیز می باشد</para> 
        /// </summary>
        public GroupListReqValidator()
        {
            RuleFor(x => x.GroupFrom).Length(2, 2).WithMessage("کد گروه' باید 2 رقم باشد'")
                .Must(ValidateGroupNum).WithMessage("مقدار کد گروه فقط می تواند شامل اعداد باشد")
                .LessThanOrEqualTo(x => x.GroupTo).WithMessage("شروع بازه ' گروه' نمی تواند از پایان آن بزرگتر باشد"); 

            RuleFor(x => x.GroupTo).Length(2, 2).WithMessage("کد گروه' باید 2 رقم باشد'")
                .Must(ValidateGroupNum).WithMessage("مقدار کد گروه فقط می تواند شامل اعداد باشد");

            When(p => p.GroupKind is not null,
             () =>
             {
                 RuleFor(x => x.GroupKind).InclusiveBetween(1, 3).WithMessage("نوع گروه' خارج از بازه ی 1 تا 3 مجاز نمی باشد'");
             });
        }
        private bool ValidateGroupNum(string grCode)
        {
            return int.TryParse(grCode, out _);
        }
    }
}
