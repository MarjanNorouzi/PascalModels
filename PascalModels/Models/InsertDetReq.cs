namespace PascalModels.Models
{
    public record InsertDetReq
    {
        /// <summary>
        /// <para><em>اسم : کد تفصیل</em></para> 
        /// <para>تعداد ارقام: 4</para> 
        /// <para>اجباری</para> 
        /// </summary>
        public string DetCode { get; set; }
        /// <summary>
        /// <para><em>اسم : نام تفصیل</em></para> 
        /// <para>حداکثر تعداد کاراکتر: 50</para> 
        /// <para>اجباری</para> 
        /// </summary>
        public string DetName { get; set; }
    }

    public record EditDetReq : InsertDetReq
    {
        /// <summary>
        /// <para><em>اسم : آی دی تفصیل</em></para> 
        /// <para>اجباری</para> 
        /// </summary>
        public int DetId { get; set; }
    }
}
