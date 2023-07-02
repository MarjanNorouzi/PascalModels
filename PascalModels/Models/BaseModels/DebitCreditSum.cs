namespace PascalModels.Models.BaseModels
{
    public class DebitCreditSum
    {
        public decimal SumOfDebit { get; set; }
        public decimal SumOfCredit { get; set; }
    }

    public class Remained : DebitCreditSum
    {
        public decimal RemainedDebit { get; set; }
        public decimal RemainedCredit { get; set; }
    }
}
