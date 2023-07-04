using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public record RemaiedReferReportReq : NumberDateFilterReq
    {
        public string DetCode { get; set; }
        public string SubCode { get; set; }
    }
    public record RemainedReferReportRes
    {
        public decimal ArtId { get; set; }
        public decimal SanadNo { get; set; }
        public DateTimeOffset DTNumDate { get; set; }
        public string Refer { get; set; }
        public string Exp { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public string Tashkhis { get; set; }
    }
    public record RemainedReferReortTotalRes : TotalDebitCredit
    {
        public string Tashkhis { get; set; }
    }
}
