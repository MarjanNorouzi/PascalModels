namespace PascalModels.Models
{
    public record InsertDetSubReq
    {
        /// <summary>
        /// <para><em>اسم : کد تفصیل</em></para> 
        /// <para>تعداد ارقام: 4</para> 
        /// <para>اجباری</para> 
        /// </summary>
        public string DetCode { get; set; }
        /// <summary>
        /// <para><em>اسم : کد های معین</em></para> 
        /// <para>تعداد ارقام هر کد: 6</para> 
        /// <para>اجباری</para> 
        /// <para>چهار رقم اول کد کلش را بیان میکند</para> 
        /// <para>کد ها در یک رشته باید با ',' جدا شوند</para> 
        /// </summary>
        public string SubCodes { get; set; }
    }

    public record EditDetSubReq : InsertDetSubReq
    {
        /// <summary>
        /// <para><em>اسم : آی دی</em></para> 
        /// </summary>
        public int DetSubId { get; set; }
    }
}
