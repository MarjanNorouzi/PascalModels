using PascalModels.Models.BaseModels;

namespace Personal_Information.Models.ProcModels
{
    public record TurnoverBySubCodeReq : NumberDateFilterReq
    {
        /// <summary>
        /// <para><em>اسم : کد معین</em></para> 
        /// <para>تعداد ارقام: 6</para> 
        /// <para>اجباری</para> 
        /// <para>چهار رقم اول کد کلش را بیان میکند</para> 
        /// </summary>
        public string SubCode { get; set; }
    }

    public record TurnoverBySubCodeRes : ReferReportRes
    {
        /// <summary>
        /// <para><em>اسم : مانده</em></para> 
        /// </summary>
        public decimal Remained { get; set; }
    }

    public record TurnoverBySubCodeTotalRes : ReferReportTotalRes
    {
    }
}
