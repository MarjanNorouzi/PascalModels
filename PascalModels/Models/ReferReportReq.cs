using PascalModels.Models;
using PascalModels.Models.BaseModels;

namespace Personal_Information.Models.ProcModels
{
    public record ReferReportReq : NumberDateFilterReq
    {
        //کد تفصیل
        //اجباری
        //باید دارای 4 رقم باشد
        public string DetCode { get; set; }
        //کد معین
        //اجباری
        //باید دارای 6 رقم باشد
        //چهار رقم اول کد کلش را بیان میکند
        public string SubCode { get; set; }
        //عطف
        //بیشترین تعداد کاراکتر 10 است
        public string Refer { get; set; }

    }

    public record ReferReportRes : RemainedReferReportRes
    {
    }

    public record ReferReportTotalRes : RemainedReferReortTotalRes
    {
        public decimal TotalRemained { get; set; }
    }
}
