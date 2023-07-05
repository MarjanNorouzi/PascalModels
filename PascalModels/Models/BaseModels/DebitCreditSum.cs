namespace PascalModels.Models.BaseModels
{
    public record DebitCreditSum
    {
        //جمع بدهکار
        public decimal SumOfDebit { get; set; }
        //جمع بستانکار
        public decimal SumOfCredit { get; set; }
    }

    public record Remained : DebitCreditSum
    {
        //مانده بدهکار
        public decimal RemainedDebit { get; set; }
        //مانده بستانکار
        public decimal RemainedCredit { get; set; }
    }
}
