namespace PascalModels.Models
{
    public record InsertSubDbReq
    {
        //کد کل
        //اجباری
        //کد مقداردهی شده باید از قبل وجود داشته باشد 
        //باید دارای 4 رقم باشد
        public string GenCode { get; set; }
        //کد معین
        //اجباری
        //باید دارای 6 رقم باشد
        //کد مقداردهی شده تکراری نباشد
        public string SubCode { get; set; }
        //نام معین
        //اجباری
        //بیشترین تعداد کاراکتر 50 است
        public string SubName { get; set; }
        //نوع تفصیل
        public bool DetKind { get; set; }
    }

    public record EditSubDbReq : InsertSubDbReq
    {
        //کد معین
        //اجباری
        public int SubId { get; set; }
    }
}
