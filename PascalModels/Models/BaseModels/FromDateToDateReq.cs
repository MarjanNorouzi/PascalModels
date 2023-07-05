using System.ComponentModel;

namespace PascalModels.Models.BaseModels
{
    public record FromDateToDateReq : BaseModel, IBaseModel
    {
        //از تاریخ
        public DateTimeOffset? FromDate { get; set; }
        //تا تاریخ
        public DateTimeOffset? ToDate { get; set; }
    }
    public record NumberDateFilterReq : FromDateToDateReq
    {
        //از شماره سند
        public int? NumFrom { get; set; }
        //تا شماره سند
        public int? NumTo { get; set; }
    }
    public record RemainedAccReq : NumberDateFilterReq
    {
        //مانده حساب
        [DefaultValue(false)]
        public bool RemainedAcc { get; set; } = false;
    }
}
