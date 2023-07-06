namespace PascalModels.Models.BaseModels
{
    public record TotalDebitCreditSum
    {
        /// <summary>
        /// <para><em>اسم : جمع کل بدهکاران</em></para> 
        /// </summary>
        public decimal TotalSumOfDebit { get; set; }
        /// <summary>
        /// <para><em>اسم : جمع کل بستانکاران</em></para> 
        /// </summary>
        public decimal TotalSumOfCredit { get; set; }
    }
    public record TotalRemained : TotalDebitCreditSum
    {
        /// <summary>
        /// <para><em>اسم : جمع مانده بدهکاران</em></para> 
        /// </summary>
        public decimal TotalRemainedDebit { get; set; }
        /// <summary>
        /// <para><em>اسم : جمع مانده بستانکاران</em></para> 
        /// </summary>
        public decimal TotalRemainedCredit { get; set; }
    }
    public record TotalDebitCredit
    {
        /// <summary>
        /// <para><em>اسم : جمع بدهکار</em></para> 
        /// </summary>
        public decimal TotalDebit { get; set; }
        /// <summary>
        /// <para><em>اسم : جمع بستانکار</em></para> 
        /// </summary>
        public decimal TotalCredit { get; set; }
    }
}
