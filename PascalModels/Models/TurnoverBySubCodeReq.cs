using PascalModels.Models.BaseModels;

namespace Personal_Information.Models.ProcModels
{
    public record TurnoverBySubCodeReq : NumberDateFilterReq
    {
        //کد معین
        //اجباری
        //باید دارای 6 رقم باشد
        //چهار رقم اول کد کلش را بیان میکند
        public string SubCode { get; set; }
    }

    public record TurnoverBySubCodeRes : ReferReportRes
    {
        //مانده
        public decimal Remained { get; set; }
    }

    public record TurnoverBySubCodeTotalRes : ReferReportTotalRes
    {
    }
}
