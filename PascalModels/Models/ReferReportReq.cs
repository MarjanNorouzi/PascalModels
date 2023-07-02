using PascalModels.Models;
using PascalModels.Models.BaseModels;

namespace Personal_Information.Models.ProcModels
{
    public class ReferReportReq : NumberDateFilterReq
    {
        public string DetCode { get; set; }
        public string SubCode { get; set; }
        public string Refer { get; set; }

    }

    public class ReferReportRes : RemainedReferReportRes
    {
    }

    public class ReferReportTotalRes : RemainedReferReortTotalRes
    {
        public decimal TotalRemained { get; set; }
    }
}
