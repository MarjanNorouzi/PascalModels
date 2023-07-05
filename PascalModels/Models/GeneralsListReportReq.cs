using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public record GeneralsListReportReq : RemainedAccReq
    {
        //از کل
        //اجباری
        //باید کوچکتر باشد 'GeneralTo' از 
        public string GeneralFrom { get; set; }
        //تا کل
        //اجباری
        //باید بزرگتر باشد 'GeneralFrom' از 
        public string GeneralTo { get; set; }
    }

    public record GeneralsListReportRes : Remained
    {
        //کد کل
        //باید دارای 4 رقم باشد
        //دورقم اول کد گروهش را بیان میکند
        public string GeneralCode { get; set; }
        //نام کل
        //بیشترین تعداد کاراکتر 50 است
        public string GeneralName { get; set; }
    }
    public record GeneralsListReportTotalRes : TotalRemained
    {
    }
}
