namespace PascalModels.Models.BaseModels
{
    public interface IBaseModel
    {
        public int CompanyCode { get; set; }
        public int FinancialYear { get; set; }
    }

    public record BaseModel
    {
        public int CompanyCode { get; set; }
        public int FinancialYear { get; set; }
    }
}
