using PascalModels.Models;
using PascalModels.Models.BaseModels;

namespace Personal_Information.Models.ProcModels
{
    public record ReferReportReq : NumberDateFilterReq
    {
        /// <summary>
        /// <para><em>اسم : کد تفصیل</em></para> 
        /// <para>تعداد ارقام: 4</para> 
        /// <para>اجباری</para> 
        /// </summary>
        public string DetCode { get; set; }
        /// <summary>
        /// <para><em>اسم : کد معین</em></para> 
        /// <para>تعداد ارقام: 6</para> 
        /// <para>اجباری</para> 
        /// <para>چهار رقم اول کد کلش را بیان میکند</para> 
        /// </summary>
        public string SubCode { get; set; }
        /// <summary>
        /// <para><em>اسم : عطف</em></para> 
        /// <para>حداکثر تعداد کاراکتر: 10</para> 
        /// </summary>
        public string Refer { get; set; }

    }

    public record ReferReportRes : RemainedReferReportRes
    {
    }

    public record ReferReportTotalRes : RemainedReferReortTotalRes
    {
        /// <summary>
        /// <para><em>اسم : جمع کل مانده</em></para> 
        /// </summary>
        public decimal TotalRemained { get; set; }
    }
}
