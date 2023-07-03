using PascalModels.Models.BaseModels;

namespace Personal_Information.Models.ProcModels
{
    public record TurnoverBySubCodeReq : NumberDateFilterReq
    {
        public string SubCode { get; set; }
    }

    public record TurnoverBySubCodeRes : ReferReportRes
    {
        public decimal Remained { get; set; }
    }

    public record TurnoverBySubCodeTotalRes : ReferReportTotalRes
    {
    }
}
