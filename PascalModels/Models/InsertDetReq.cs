namespace PascalModels.Models
{
    public record InsertDetReq
    {
        //کد تفصیل
        //اجباری
        //باید دارای 4 رقم باشد
        public string DetCode { get; set; }
        //نام تفصیل
        //اجباری
        //بیشترین تعداد کاراکتر 50 است
        public string DetName { get; set; }
    }

    public record EditDetReq : InsertDetReq
    {
        //آی دی تفصیل
        //اجباری
        public int DetId { get; set; }
    }
}
