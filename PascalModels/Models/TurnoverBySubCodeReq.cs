using PascalModels.Models.BaseModels;
using System.ComponentModel.DataAnnotations;

namespace Personal_Information.Models.ProcModels
{
    public class TurnoverBySubCodeReq : NumberDateFilterReq
    {
        [StringLength(10)]
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
