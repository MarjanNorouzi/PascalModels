namespace PascalModels.Models.BaseModels
{
    public interface IBaseModel
    {
        public int CompanyCode { get; set; }
        public int FinancialYear { get; set; }
    }

    public class BaseModel
    {
        public int CompanyCode { get; set; }
        public int FinancialYear { get; set; }
    }
}
