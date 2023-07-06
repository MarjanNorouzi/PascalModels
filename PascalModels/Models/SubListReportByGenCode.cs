using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public record SubListReportByGenCodeReq : RemainedAccReq
    {
        /// <summary>
        /// <para><em>اسم : کد کل</em></para> 
        /// <para>تعداد ارقام: 4</para> 
        /// <para>اجباری</para> 
        /// <para>دورقم اول کد گروهش را بیان میکند</para> 
        /// </summary>
        public string GeneralCode { get; set; }
    }

    public record SubListReportByGenCodeRes : Remained
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
    public record SubListReportByGenCodeTotalRes : TotalRemained
    {
    }
}
