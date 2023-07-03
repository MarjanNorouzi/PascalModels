using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public record SubListReportByDetAndSubCodeReq : NumberDateFilterReq
    {
        public string DetCode { get; set; }
        public string SubCode { get; set; }
    }
    public record SubListReportByDetAndSubCodeRes : RemainedReferReportRes
    {
        public int Remained { get; set; }
    }
    public record SubListReportByDetAndSubCodeTotalRes : TotalRemained
    {
    }
}
