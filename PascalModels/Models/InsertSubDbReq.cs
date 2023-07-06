namespace PascalModels.Models
{
    public record InsertSubDbReq
    {
        /// <summary>
        /// <para><em>اسم : کد کل</em></para> 
        /// <para>تعداد ارقام: 4</para> 
        /// <para>اجباری</para> 
        /// <para>کد مقداردهی شده باید از قبل وجود داشته باشد </para> 
        /// <para>دورقم اول کد گروهش را بیان میکند</para> 
        /// </summary>
        public string GenCode { get; set; }
        /// <summary>
        /// <para><em>اسم : کد معین</em></para> 
        /// <para>تعداد ارقام: 6</para> 
        /// <para>اجباری</para> 
        /// <para>کد مقداردهی شده تکراری نباشد </para> 
        /// <para>چهار رقم اول کد کلش را بیان میکند</para> 
        /// </summary>
        public string SubCode { get; set; }
        /// <summary>
        /// <para><em>اسم : نام معین</em></para> 
        /// <para>حداکثر تعداد کاراکتر: 50</para> 
        /// <para>اجباری</para> 
        /// </summary>
        public string SubName { get; set; }
        /// <summary>
        /// <para><em>اسم : نوع تفصیل</em></para> 
        /// <para>اجباری</para> 
        /// </summary>
        public bool DetKind { get; set; }
    }

    public record EditSubDbReq : InsertSubDbReq
    {
        /// <summary>
        /// <para><em>اسم : کد معین</em></para> 
        /// <para>اجباری</para> 
        /// </summary>
        public int SubId { get; set; }
    }
}
