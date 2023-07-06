namespace PascalModels.Models
{
    public record InsertGrDbReq
    {
        /// <summary>
        /// <para><em>اسم : کدگروه</em></para> 
        /// <para>تعداد ارقام: 2</para> 
        /// <para>اجباری</para> 
        /// <para>کد مقداردهی شده تکراری نباشد</para> 
        /// </summary>
        public string GrCode { get; set; }
        /// <summary>
        /// <para><em>اسم : نام گروه</em></para> 
        /// <para>حداکثر تعداد کاراکتر: 50</para> 
        /// <para>اجباری</para> 
        /// </summary>
        public string GrName { get; set; }
        /// <summary>
        /// <para><em>اسم : نوع گروه</em></para> 
        /// <para>اجباری</para> 
        /// </summary>
        public int Grkind { get; set; }

    }

    public record EditGrDbReq : InsertGrDbReq
    {
        /// <summary>
        /// <para><em>اسم : آی دی گروه</em></para> 
        /// <para>اجباری</para> 
        /// </summary>
        public int GrId { get; set; }
    }

}
