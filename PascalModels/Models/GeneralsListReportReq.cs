using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public record GeneralsListReportReq : RemainedAccReq
    {
        /// <summary>
        /// <para>اسم : از کل</para> 
        /// <para>باید کوچکتر باشد 'GeneralTo' از </para> 
        /// <para>اجباری</para> 
        /// <para>تعداد ارقام: 4</para> 
        /// </summary>
        /// <example>0101</example>
        public string GeneralFrom { get; set; }

        /// <summary>
        /// <para>اسم : تا کل</para> 
        /// <para>باید بزرگتر باشد 'GeneralFrom' از </para> 
        /// <para>اجباری</para> 
        /// <para>تعداد ارقام: 4</para> 
        /// </summary>
        /// <example>0701</example>
        public string GeneralTo { get; set; }
    }

    public record GeneralsListReportRes : Remained
    {
        /// <summary>
        /// <para><em>اسم : کد کل</em></para> 
        /// <para>تعداد ارقام: 4</para> 
        /// <para>دو رقم اول کد گروهش را بیان میکند</para> 
        /// </summary>
        public string GeneralCode { get; set; }

        /// <summary>
        /// <para><em>اسم : نام کل</em></para> 
        /// <para>بیشترین تعداد کاراکتر 50 است</para> 
        /// </summary>
        public string GeneralName { get; set; }
    }
    public record GeneralsListReportTotalRes : TotalRemained
    {
    }
}
