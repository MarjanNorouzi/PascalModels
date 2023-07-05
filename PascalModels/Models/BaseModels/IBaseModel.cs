namespace PascalModels.Models.BaseModels
{
    public interface IBaseModel
    {
        //کدکمپانی
        //اجباری
        //باید دارای دو رقم باشد
        public string CompanyCode { get; set; }
        //سال مالی
        //اجباری
        //باید دارای دو رقم باشد
        public string FinancialYear { get; set; }
    }

    public record BaseModel
    {
        //کدکمپانی
        //اجباری
        //باید دارای دو رقم باشد
        public string CompanyCode { get; set; }
        //سال مالی
        //اجباری
        //باید دارای دو رقم باشد
        public string FinancialYear { get; set; }
    }
}
