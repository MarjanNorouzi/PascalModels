namespace PascalModels.Models.BaseModels
{
    public record DebitCreditSum
    {
        public decimal SumOfDebit { get; set; }
        public decimal SumOfCredit { get; set; }
    }

    public record Remained : DebitCreditSum
    {
        public decimal RemainedDebit { get; set; }
        public decimal RemainedCredit { get; set; }
    }
}
