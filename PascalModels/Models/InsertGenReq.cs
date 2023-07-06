namespace PascalModels.Models
{
    public record InsertGenReq
    {
        /// <summary>
        /// <para><em>اسم : کدگروه</em></para> 
        /// <para>تعداد ارقام: 2</para> 
        /// <para>اجباری</para> 
        /// <para>کد مقداردهی شده باید از قبل وجود داشته باشد</para> 
        /// </summary>
        public string GroupCode { get; set; }
        /// <summary>
        /// <para><em>اسم : کد کل</em></para> 
        /// <para>تعداد ارقام: 4</para> 
        /// <para>اجباری</para> 
        /// <para>دورقم اول کد گروهش را بیان میکند</para> 
        /// </summary>
        public string GenCode { get; set; }
        //نام کل
        //اجباری
        //بیشترین تعداد کاراکتر 50 است
        /// <summary>
        /// <para><em>اسم : نام کل</em></para> 
        /// <para>حداکثر تعداد کاراکتر: 50</para> 
        /// <para>اجباری</para> 
        /// </summary>
        public string GenName { get; set; }
    }

    public record EditGenReq : InsertGenReq
    {
        /// <summary>
        /// <para><em>اسم : آی دی کل</em></para> 
        /// <para>اجباری</para> 
        /// </summary>
        public int GenId { get; set; }
    }
}
