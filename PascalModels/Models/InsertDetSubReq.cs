namespace PascalModels.Models
{
    public record InsertDetSubReq
    {
        //کد تفصیل
        //اجباری
        //باید دارای 4 رقم باشد
        public string DetCode { get; set; }
        //کد های معین
        //اجباری
        //کد ها در یک رشته باید با ',' جدا شوند
        //هر کد باید دارای 6 رقم باشد
        //چهار رقم اول کد کلش را بیان میکند
        public string SubCodes { get; set; }
    }

    public record EditDetSubReq : InsertDetSubReq
    {
        //آی دی 
        public int DetSubId { get; set; }
    }
}
