using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public class SubListReportByDetCodeReq : RemainedAccReq
    {
        public string DetCode { get; set; }
    }
    public class SubListReportByDetCodeRes : Remained
    {
        public string SubCode { get; set; }
        public string SubName { get; set; }
        public bool HasDetail { get; set; }
    }
    public class SubListReportByDetCodeTotalRes : TotalRemained
    {
    }
}
