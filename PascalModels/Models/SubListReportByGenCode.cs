using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public class SubListReportByGenCodeReq : RemainedAccReq
    {
        public string GeneralCode { get; set; }
    }

    public class SubListReportByGenCodeRes : Remained
    {
        public string SubCode { get; set; }
        public string SubName { get; set; }
        public bool HasDetail { get; set; }
    }
    public class SubListReportByGenCodeTotalRes : TotalRemained
    {
    }
}
