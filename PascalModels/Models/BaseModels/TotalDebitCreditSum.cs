namespace PascalModels.Models.BaseModels
{
    public record TotalDebitCreditSum
    {
        public decimal TotalSumOfDebit { get; set; }
        public decimal TotalSumOfCredit { get; set; }
    }
    public record TotalRemained : TotalDebitCreditSum
    {
        public decimal TotalRemainedDebit { get; set; }
        public decimal TotalRemainedCredit { get; set; }
    }
    public record TotalDebitCredit
    {
        public decimal TotalDebit { get; set; }
        public decimal TotalCredit { get; set; }
    }
}
