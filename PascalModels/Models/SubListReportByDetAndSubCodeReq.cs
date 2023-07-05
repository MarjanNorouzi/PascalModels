using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public record SubListReportByDetAndSubCodeReq : NumberDateFilterReq
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
    public record SubListReportByDetAndSubCodeRes : RemainedReferReportRes
    {
        //مانده
        public decimal Remained { get; set; }
    }
    public record SubListReportByDetAndSubCodeTotalRes : TotalRemained
    {
    }
}
