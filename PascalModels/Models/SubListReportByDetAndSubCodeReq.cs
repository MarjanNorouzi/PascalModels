using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public class SubListReportByDetAndSubCodeReq : FromSanadNoToNoReq
    {
        public string DetCode { get; set; }
        public string SubCode { get; set; }
    }
    public class SubListReportByDetAndSubCodeRes : RemainedReferReortRes
    {
        public int Remained { get; set; }
    }
    public class SubListReportByDetAndSubCodeTotalRes : TotalRemained
    {
    }
}
