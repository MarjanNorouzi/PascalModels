using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public record RefersReportReq : NumberDateFilterReq
    {
        //کد تفصیل
        //باید دارای 4 رقم باشد
        public string DetCode { get; set; }
        //کد معین
        //اجباری
        //باید دارای 6 رقم باشد
        //چهار رقم اول کد کلش را بیان میکند
        public string SubCode { get; set; }
    }
    public record RefersReportRes : Remained
    {
        //شماره سند
        public int Number { get; set; }
        //عطف
        //بیشترین تعداد کاراکتر 10 است
        public string Refer { get; set; }
        //فلگ
        //اگر جمع بدهکار و بستانکار 0 شد فلگ برابر با0 میشود و در غیر این صورت مقدار 1 میشود
        public bool Flag { get; set; }
    }
}
