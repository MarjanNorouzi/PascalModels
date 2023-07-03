﻿using FluentValidation;
using PascalModels.Models;

namespace PascalModels.Validations
{
    public class InsertGrDbReqValidator : AbstractValidator<InsertGrDbReq>
    {
        //همه موارد باید مقداردهی شوند
        public InsertGrDbReqValidator()
        {
            RuleFor(x => x.GrCode).NotEmpty().NotNull().WithMessage("لطفا کد گروه را وارد کنید")
                                  .MaximumLength(2).WithMessage("بیش از 2 کاراکتر مجاز نمی باشد")
                                  .Must(ValidateGrCode).WithMessage("مقدار کد گروه فقط می تواند عدد صحیح باشد");

            RuleFor(x => x.GrName).NotEmpty().NotNull().WithMessage("لطفا نام گروه را وارد کنید")
                                  .MaximumLength(50).WithMessage("بیش از 50 کاراکتر مجاز نمی باشد");

            RuleFor(x => x.Grkind).NotEmpty().NotNull().WithMessage("لطفا نوع گروه را وارد کنید");
        }
        private bool ValidateGrCode(string grCode)
        {
            return int.TryParse(grCode, out int b);
        }
    }
}