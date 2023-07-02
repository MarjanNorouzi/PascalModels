namespace PascalModels.Models.BaseModels
{
    public class FromDateToDateReq
    {
        public DateTimeOffset? FromDate { get; set; }
        public DateTimeOffset? ToDate { get; set; }
    }
    public class NumberDateFilterReq : FromDateToDateReq
    {
        public int? NumFrom { get; set; }
        public int? NumTo { get; set; }
    }
    public class RemainedAccReq : NumberDateFilterReq
    {
        public bool RemainedAcc { get; set; } = false;
    }
} 
