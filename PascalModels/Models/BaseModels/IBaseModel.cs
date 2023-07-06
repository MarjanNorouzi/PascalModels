namespace PascalModels.Models.BaseModels
{
    public interface IBaseModel
    {
        /// <summary>
        /// <para><em>اسم : کد کمپانی</em></para> 
        /// <para>تعداد ارقام: 2</para> 
        /// <para>اجباری</para> 
        /// </summary>
        public string CompanyCode { get; set; }
        /// <summary>
        /// <para><em>اسم : سال مالی</em></para> 
        /// <para>تعداد ارقام: 2</para> 
        /// <para>اجباری</para> 
        /// </summary>
        public string FinancialYear { get; set; }
    }

    public record BaseModel
    {
        /// <summary>
        /// <para><em>اسم : کد کمپانی</em></para> 
        /// <para>تعداد ارقام: 2</para> 
        /// <para>اجباری</para> 
        /// </summary>
        public string CompanyCode { get; set; }
        /// <summary>
        /// <para><em>اسم : سال مالی</em></para> 
        /// <para>تعداد ارقام: 2</para> 
        /// <para>اجباری</para> 
        /// </summary>
        public string FinancialYear { get; set; }
    }
}
