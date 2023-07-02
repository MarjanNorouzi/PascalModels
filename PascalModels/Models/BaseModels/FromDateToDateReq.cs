namespace PascalModels.Models.BaseModels
{
    public class FromDateToDateReq
    {
        public DateTimeOffset FromDate { get; set; }
        public DateTimeOffset ToDate { get; set; }
    }
    public class FromSanadNoToNoReq : FromDateToDateReq
    {
        public int NumFrom { get; set; }
        public int NumTo { get; set; }
    }
    public class RemainedAccReq : FromSanadNoToNoReq
    {
        public bool RemainedAcc { get; set; } = false;
    }
}
