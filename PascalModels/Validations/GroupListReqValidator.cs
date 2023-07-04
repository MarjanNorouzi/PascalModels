﻿using FluentValidation;
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
            RuleFor(x => x.GroupFrom).Length(2, 2).WithMessage("تعداد 2 کاراکتر مجاز می باشد")
                                     .Must(ValidateGroupNum).WithMessage("مقدار کد گروه فقط می تواند شامل اعداد باشد")
                                     .LessThanOrEqualTo(x => x.GroupTo).WithMessage("بازه وارد شده صحیح نمی باشد"); //"the selected range is incorrect.";

            RuleFor(x => x.GroupTo).Length(2, 2).WithMessage("تعداد 2 کاراکتر مجاز می باشد")
                                   .Must(ValidateGroupNum).WithMessage("مقدار کد گروه فقط می تواند شامل اعداد باشد");

            When(p => p.GroupKind is not null,
             () =>
             {
                 RuleFor(x => x.GroupKind).InclusiveBetween(1, 3).WithMessage("خارج از بازه ی 1 تا 3 مجاز نمی باشد");
             });
        }
        private bool ValidateGroupNum(string grCode)
        {
            return int.TryParse(grCode, out _);
        }
    }
}
