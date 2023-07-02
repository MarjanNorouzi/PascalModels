using PascalModels.Models;
using PascalModels.Models.BaseModels;
using System.ComponentModel.DataAnnotations;

namespace Personal_Information.Models.ProcModels
{
    public class ReferReportReq : NumberDateFilterReq
    {
        [StringLength(8)]
        public string DetCode { get; set; }

        [StringLength(10)]
        public string SubCode { get; set; }

        [StringLength(10)]
        public string Refer { get; set; }

    }

    public class ReferReportRes 
    {
        public int RowNo { get; set; }
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTimeOffset DTNumberDate { get; set; }
        [StringLength(10)]
        public string Refer { get; set; }
        [StringLength(3800)]
        public string Exp { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        [StringLength(2)]
        public string Assessment { get; set; }
    }

    public class ReferReportTotalRes : RemainedReferReortTotalRes
    {
        public decimal TotalRemained { get; set; }
    }
}
