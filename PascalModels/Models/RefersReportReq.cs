using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public record RefersReportReq : NumberDateFilterReq
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
    public record RefersReportRes : Remained
    {
        /// <summary>
        /// <para><em>اسم : شماره سند</em></para> 
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// <para><em>اسم : عطف</em></para> 
        /// <para>حداکثر تعداد کاراکتر: 10</para> 
        /// </summary>
        public string Refer { get; set; }
        /// <summary>
        /// <para><em>اسم : فلگ</em></para> 
        /// <para>اگر جمع بدهکار و بستانکار 0 شد فلگ برابر با0 میشود و در غیر این صورت مقدار 1 میشود</para> 
        /// </summary>
        public bool Flag { get; set; }
    }
}
