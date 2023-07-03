using PascalModels.Models;
using PascalModels.Models.BaseModels;

namespace Personal_Information.Models.ProcModels
{
    public record ReferReportReq : NumberDateFilterReq
    {
        public string DetCode { get; set; }
        public string SubCode { get; set; }
        public string Refer { get; set; }

    }

    public record ReferReportRes : RemainedReferReportRes
    {
    }

    public record ReferReportTotalRes : RemainedReferReortTotalRes
    {
        public decimal TotalRemained { get; set; }
    }
}
