namespace PascalModels.Models
{
    public record InsertGenReq
    {
        //کدگروه
        //اجباری
        //کد مقداردهی شده باید از قبل وجود داشته باشد
        //باید دارای 2 رقم باشد
        public string GroupCode { get; set; }
        //کد کل
        //اجباری
        //باید دارای 4 رقم باشد 
        //دورقم اول کد گروهش را بیان میکند
        public string GenCode { get; set; }
        //نام کل
        //اجباری
        //بیشترین تعداد کاراکتر 50 است
        public string GenName { get; set; }
    }

    public record EditGenReq : InsertGenReq
    {
        //آی دی کل
        //اجباری
        public int GenId { get; set; }
    }
}
