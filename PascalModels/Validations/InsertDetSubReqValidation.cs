using FluentValidation;
using PascalModels.Models;
using System.Text.RegularExpressions;

namespace PascalModels.Validations
{
    public class InsertDetSubReqValidation : AbstractValidator<InsertDetSubReq>
    {
        public InsertDetSubReqValidation()
        {
            RuleFor(x => x.DetCode).NotEmpty().NotNull().WithMessage("لطفا کد تفصیل را وارد کنید")
                                   .MaximumLength(6).WithMessage("بیش از 8 کاراکتر مجاز نمی باشد")
                                   .Must(ValidateCode).WithMessage("مقدار کد تفصیل فقط می تواند عدد صحیح باشد");

            RuleFor(x => x.SubCodes).NotEmpty().NotNull().WithMessage("لطفا کدهای معین را وارد کنید")
                                    .Must(ValidateSubCodes).WithMessage("مقدار کدهای معین فقط می تواند عددهای صحیح جدا شده با(,) باشد");
        }

        private bool ValidateCode(string Code)
        {
            return int.TryParse(Code, out int _);
        }
        private bool ValidateSubCodes(string Codes)
        {
            //check just (0 to 9 and ,) is valid
            if (!Regex.IsMatch(Codes, @"^[0-9]+$"))
                return false;

            else
                return true;
        }
    }
}
