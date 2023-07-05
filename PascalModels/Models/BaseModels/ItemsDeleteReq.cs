namespace PascalModels.Models.BaseModels
{
    public record ItemsDeleteReq
    {
        //این کلاس برای پاک کردن همه آیتم ها استفاده میشود 
        //آی دی
        public IEnumerable<int> Ids { get; set; }
    }
}
