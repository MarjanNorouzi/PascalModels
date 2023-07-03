using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public record GeneralsListReportReq : RemainedAccReq
    {
        public string GeneralFrom { get; set; }
        public string GeneralTo { get; set; }
    }

    public record GeneralsListReportRes : Remained
    {
        public string GeneralCode { get; set; }
        public string GeneralName { get; set; }
    }
    public record GeneralsListReportTotalRes : TotalRemained
    {
    }
}
