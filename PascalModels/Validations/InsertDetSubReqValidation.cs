using FluentValidation;
using PascalModels.Models;
using System.Text.RegularExpressions;

namespace PascalModels.Validations
{
    public class InsertDetSubReqValidation : AbstractValidator<InsertDetSubReq>
    {
        public InsertDetSubReqValidation()
        {
            RuleFor(x => x.DetCode)
                .NotEmpty().NotNull().WithMessage("کد تفصیل نمی تواند خالی باشد")
                .Length(4, 4).WithMessage("کد تفصیل باید 4 رقم باشد")
                .Must(ValidateCode).WithMessage("مقدار کد تفصیل فقط می تواند عدد صحیح باشد");

            RuleFor(x => x.SubCodes)
                .NotEmpty().NotNull().WithMessage("کد های معین نمیتوانند خالی باشند")
                .Must(ValidateSubCodes).WithMessage("مقدار کدهای معین فقط می تواند عددهای صحیح جدا شده با(,) باشد");
        }

        private bool ValidateCode(string code)
        {
            return int.TryParse(code, out int _);
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
