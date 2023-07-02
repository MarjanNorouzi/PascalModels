using FluentValidation;
using PascalModels.Models.BaseModels;
using Personal_Information.Validators.SQLValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalModels.Validations
{
    public class GeneralsListReportByGrCodeReqValidator : AbstractValidator<GeneralsListReportByGrCodeReq>
    {
        public GeneralsListReportByGrCodeReqValidator()
        {
            When(p =>
                       (string.IsNullOrWhiteSpace(p.GrCode)),
                       () =>
                       {
                           RuleFor(x => x.GrCode).NotEmpty().WithMessage("لطفا کد گروه را وارد کنید");
                       }).Otherwise(
                                    () =>
                                    {
                                        Include(new NumberDateFilterReqValidator());
                                        RuleFor(x => x.GrCode).MaximumLength(2);
                                    });
           
        }
    }
}
