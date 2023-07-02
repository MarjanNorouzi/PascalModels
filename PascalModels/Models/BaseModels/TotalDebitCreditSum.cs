namespace PascalModels.Models.BaseModels
{
    public class TotalDebitCreditSum
    {
        public decimal TotalSumOfDebit { get; set; }
        public decimal TotalSumOfCredit { get; set; }
    }
    public class TotalRemained : TotalDebitCreditSum
    {
        public decimal TotalRemainedDebit { get; set; }
        public decimal TotalRemainedCredit { get; set; }
    }
    public class TotalDebitCredit
    {
        public decimal TotalDebit { get; set; }
        public decimal TotalCredit { get; set; }
    }
}
