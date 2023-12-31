﻿using FluentValidation;
using PascalModels.Models;

namespace PascalModels.Validations
{
    public class InsertGrDbReqValidator : AbstractValidator<InsertGrDbReq>
    {
        /// <summary>
        /// <para><em>افزودن گروه</em></para>
        /// <para>همه موارد(کد گروه شامل 2 عدد)و(نام گروه که شامل کاراکتر میباشد)و(نوع گروه) باید مقداردهی شوند</para> 
        /// </summary>
        public InsertGrDbReqValidator()
        {
            RuleFor(x => x.GrCode).NotEmpty().NotNull().WithMessage("لطفا کد گروه را وارد کنید")
                .Length(2, 2).WithMessage("کد گروه' باید 2 رقم باشد'")
                .Must(ValidateGrCode).WithMessage("مقدار کد گروه فقط می تواند عدد صحیح باشد");

            RuleFor(x => x.GrName).NotEmpty().NotNull().WithMessage("لطفا نام گروه را وارد کنید")
                .MaximumLength(50).WithMessage("بیش از 50 کاراکتر مجاز نمی باشد");

            RuleFor(x => x.Grkind).NotEmpty().NotNull().WithMessage("لطفا نوع گروه را وارد کنید");
        }
        private bool ValidateGrCode(string grCode)
        {
            return int.TryParse(grCode, out _);
        }
    }
}
