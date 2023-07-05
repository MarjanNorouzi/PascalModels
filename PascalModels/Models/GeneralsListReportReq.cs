using PascalModels.Models.BaseModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PascalModels.Models
{
    public record GeneralsListReportReq : RemainedAccReq
    {
        /// <summary>
        /// <para>اسم : از کل</para> 
        /// <para>باید کوچکتر باشد 'GeneralTo' از </para> 
        /// <para>تعداد ارقام: 4</para> 
        /// </summary>
        /// <example>0102</example>
        [Required]
        [MinLength(4)]
        [DisplayName("از کل")]
        //[DefaultValue("0101")]
        public string GeneralFrom { get; set; }

        /// <summary>
        /// <para>اسم : تا کل</para> 
        /// <para>باید بزرگتر باشد 'GeneralFrom' از </para> 
        /// <para>تعداد ارقام: 4</para> 
        /// </summary>
        /// <example>0703</example>
        [Required]
        [MinLength(4)]
        //[DefaultValue("0703")]
        public string GeneralTo { get; set; }
    }

    public record GeneralsListReportRes : Remained
    {
        /// <summary>
        /// <para><em>اسم : کد کل</em></para> 
        /// <para>تعداد ارقام: 4</para> 
        /// <para>دو رقم اول کد گروهش را بیان میکند</para> 
        /// </summary>
        [DefaultValue("0101")]
        public string GeneralCode { get; set; }

        /// <summary>
        /// <para><em>اسم : نام کل</em></para> 
        /// <para>بیشترین تعداد کاراکتر 50 است</para> 
        /// </summary>
        [DefaultValue("موجوديهاي نقد و بانک")]
        public string GeneralName { get; set; }
    }
    public record GeneralsListReportTotalRes : TotalRemained
    {
    }
}
