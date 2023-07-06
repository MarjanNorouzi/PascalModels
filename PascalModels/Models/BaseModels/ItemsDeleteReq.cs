namespace PascalModels.Models.BaseModels
{
    public record ItemsDeleteReq
    {
        /// <summary>
        /// <para><em>اسم : آی دی</em></para> 
        /// <para>برای پاک کردن همه آیتم ها استفاده میشود</para> 
        /// </summary>
        public IEnumerable<int> Ids { get; set; }
    }
}
