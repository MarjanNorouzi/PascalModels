namespace PascalModels.Models.BaseModels
{
    public record FromDateToDateReq : BaseModel, IBaseModel
    {
        public DateTimeOffset? FromDate { get; set; }
        public DateTimeOffset? ToDate { get; set; }
    }
    public record NumberDateFilterReq : FromDateToDateReq
    {
        public int? NumFrom { get; set; }
        public int? NumTo { get; set; }
    }
    public record RemainedAccReq : NumberDateFilterReq
    {
        public bool RemainedAcc { get; set; } = false;
    }
}
