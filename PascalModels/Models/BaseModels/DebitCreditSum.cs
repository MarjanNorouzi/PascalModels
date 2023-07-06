namespace PascalModels.Models.BaseModels
{
    public record DebitCreditSum
    {
        /// <summary>
        /// <para><em>اسم : جمع بدهکار</em></para> 
        /// </summary>
        public decimal SumOfDebit { get; set; }
        /// <summary>
        /// <para><em>اسم : جمع بستانکار</em></para> 
        /// </summary>
        public decimal SumOfCredit { get; set; }
    }

    public record Remained : DebitCreditSum
    {
        /// <summary>
        /// <para><em>اسم : مانده بدهکار</em></para> 
        /// </summary>
        public decimal RemainedDebit { get; set; }
        /// <summary>
        /// <para><em>اسم : مانده بستانکار</em></para> 
        /// </summary>
        public decimal RemainedCredit { get; set; }
    }
}
