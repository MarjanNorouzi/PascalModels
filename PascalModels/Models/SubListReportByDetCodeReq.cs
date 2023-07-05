using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public record SubListReportByDetCodeReq : RemainedAccReq
    {
        //کد تفصیل
        //اجباری
        //باید دارای 4 رقم باشد
        public string DetCode { get; set; }
    }
    public record SubListReportByDetCodeRes : Remained
    {
        //کد معین
        //باید دارای 6 رقم باشد
        //چهار رقم اول کد کلش را بیان میکند
        public string SubCode { get; set; }
        //نام معین
        //بیشترین تعداد کاراکتر 50 است
        public string SubName { get; set; }
        public bool HasDetail { get; set; }
    }
    public record SubListReportByDetCodeTotalRes : TotalRemained
    {
    }
}
