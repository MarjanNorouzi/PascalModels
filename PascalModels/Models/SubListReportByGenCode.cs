using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public record SubListReportByGenCodeReq : RemainedAccReq
    {
        public string GeneralCode { get; set; }
    }

    public record SubListReportByGenCodeRes : Remained
    {
        public string SubCode { get; set; }
        public string SubName { get; set; }
        public bool HasDetail { get; set; }
    }
    public record SubListReportByGenCodeTotalRes : TotalRemained
    {
    }
}
