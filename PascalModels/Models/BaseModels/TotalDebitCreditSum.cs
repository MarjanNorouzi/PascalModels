namespace PascalModels.Models.BaseModels
{
    public record TotalDebitCreditSum
    {
        //جمع بدهکاران
        public decimal TotalSumOfDebit { get; set; }
        //جمع بستانکاران
        public decimal TotalSumOfCredit { get; set; }
    }
    public record TotalRemained : TotalDebitCreditSum
    {
        //جمع مانده بدهکاران
        public decimal TotalRemainedDebit { get; set; }
        //جمع مانده بستانکاران
        public decimal TotalRemainedCredit { get; set; }
    }
    public record TotalDebitCredit
    {
        //جمع بدهکار
        public decimal TotalDebit { get; set; }
        //جمع بستانکار
        public decimal TotalCredit { get; set; }
    }
}
