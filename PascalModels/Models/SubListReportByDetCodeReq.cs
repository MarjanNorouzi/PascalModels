using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public record SubListReportByDetCodeReq : RemainedAccReq
    {
        /// <summary>
        /// <para><em>اسم : کد تفصیل</em></para> 
        /// <para>تعداد ارقام: 4</para> 
        /// <para>اجباری</para> 
        /// </summary>
        public string DetCode { get; set; }
    }
    public record SubListReportByDetCodeRes : Remained
    {
        /// <summary>
        /// <para><em>اسم : کد معین</em></para> 
        /// <para>تعداد ارقام: 6</para> 
        /// <para>چهار رقم اول کد کلش را بیان میکند</para> 
        /// </summary>
        public string SubCode { get; set; }
        /// <summary>
        /// <para><em>اسم : نام معین</em></para> 
        /// <para>حداکثر تعداد کاراکتر: 50</para> 
        /// </summary>
        public string SubName { get; set; }
        public bool HasDetail { get; set; }
    }
    public record SubListReportByDetCodeTotalRes : TotalRemained
    {
    }
}
