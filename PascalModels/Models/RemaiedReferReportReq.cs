using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public record RemaiedReferReportReq : NumberDateFilterReq
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
    public record RemainedReferReportRes
    {
        /// <summary>
        /// <para><em>اسم : آی دی</em></para> 
        /// </summary>
        public int ArtId { get; set; }
        /// <summary>
        /// <para><em>اسم : شماره سند</em></para> 
        /// </summary>
        public int SanadNo { get; set; }
        /// <summary>
        /// <para><em>اسم : تاریخ</em></para> 
        /// </summary>
        public DateTimeOffset DTNumDate { get; set; }
        /// <summary>
        /// <para><em>اسم : عطف</em></para> 
        /// <para>حداکثر تعداد کاراکتر: 10</para> 
        /// </summary>
        public string Refer { get; set; }
        /// <summary>
        /// <para>حداکثر تعداد کاراکتر: 50</para> 
        /// </summary>
        public string Exp { get; set; }
        //بدهکار
        /// <summary>
        /// <para><em>اسم : بدهکار</em></para> 
        /// </summary>
        public decimal Debit { get; set; }
        /// <summary>
        /// <para><em>اسم : بستانکار</em></para> 
        /// </summary>
        public decimal Credit { get; set; }
        /// <summary>
        /// <para><em>اسم : تشخیص</em></para> 
        /// <para>تعداد کاراکتر: 2</para> 
        /// <para>بس'و'بد'و مقدار خالی را نشان میدهد'</para> 
        /// </summary>
        public string Tashkhis { get; set; }
    }
    public record RemainedReferReortTotalRes : TotalDebitCredit
    {
        /// <summary>
        /// <para><em>اسم : تشخیص</em></para> 
        /// <para>تعداد کاراکتر: 2</para> 
        /// <para>بس'و'بد'و مقدار خالی را نشان میدهد'</para> 
        /// </summary>
        public string Tashkhis { get; set; }
    }
}
