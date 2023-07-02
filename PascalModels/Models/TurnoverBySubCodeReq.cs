using PascalModels.Models.BaseModels;

namespace Personal_Information.Models.ProcModels
{
    public class TurnoverBySubCodeReq : NumberDateFilterReq
    {
        public string SubCode { get; set; }
    }

    public class TurnoverBySubCodeRes : ReferReportRes
    {
        public decimal Remained { get; set; }
    }

    public class TurnoverBySubCodeTotalRes : ReferReportTotalRes
    {
    }
}
