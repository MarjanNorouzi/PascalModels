using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public record SubListReportByDetCodeReq : RemainedAccReq
    {
        public string DetCode { get; set; }
    }
    public record SubListReportByDetCodeRes : Remained
    {
        public string SubCode { get; set; }
        public string SubName { get; set; }
        public bool HasDetail { get; set; }
    }
    public record SubListReportByDetCodeTotalRes : TotalRemained
    {
    }
}
