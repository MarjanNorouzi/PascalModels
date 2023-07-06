using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public record SubListReportByDetAndSubCodeReq : NumberDateFilterReq
    {
        /// <summary>
        /// <para><em>اسم : کد تفصیل</em></para> 
        /// <para>تعداد ارقام: 4</para> 
        /// </summary>
        public string DetCode { get; set; }
        /// <summary>
        /// <para><em>اسم : کد معین</em></para> 
        /// <para>تعداد ارقام: 6</para> 
        /// <para>اجباری</para> 
        /// <para>چهار رقم اول کد کلش را بیان میکند</para> 
        /// </summary>
        public string SubCode { get; set; }
    }
    public record SubListReportByDetAndSubCodeRes : RemainedReferReportRes
    {
        /// <summary>
        /// <para><em>اسم : مانده</em></para> 
        /// <para>تعداد ارقام: 6</para> 
        /// <para>چهار رقم اول کد کلش را بیان میکند</para> 
        /// </summary>
        public decimal Remained { get; set; }
    }
    public record SubListReportByDetAndSubCodeTotalRes : TotalRemained
    {
    }
}
