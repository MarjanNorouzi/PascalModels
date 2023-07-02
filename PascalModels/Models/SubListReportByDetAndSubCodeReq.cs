using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public class SubListReportByDetAndSubCodeReq : NumberDateFilterReq
    {
        public string DetCode { get; set; }
        public string SubCode { get; set; }
    }
    public class SubListReportByDetAndSubCodeRes : RemainedReferReportRes
    {
        public int Remained { get; set; }
    }
    public class SubListReportByDetAndSubCodeTotalRes : TotalRemained
    {
    }
}
