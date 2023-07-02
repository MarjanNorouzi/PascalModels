using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public class GeneralsListReportReq : RemainedAccReq
    {
        public string GeneralFrom { get; set; }
        public string GeneralTo { get; set; }
    }

    public class GeneralsListReportRes : Remained
    {
        public string GeneralCode { get; set; }
        public string GeneralName { get; set; }
    }
    public class GeneralsListReportTotalRes : TotalRemained
    {
    }
}
