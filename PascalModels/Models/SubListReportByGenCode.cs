using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public record SubListReportByGenCodeReq : RemainedAccReq
    {
        //کد کل
        //اجباری
        //باید دارای 4 رقم باشد 
        //دورقم اول کد گروهش را بیان میکند
        public string GeneralCode { get; set; }
    }

    public record SubListReportByGenCodeRes : Remained
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
    public record SubListReportByGenCodeTotalRes : TotalRemained
    {
    }
}
