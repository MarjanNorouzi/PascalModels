using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public record RemaiedReferReportReq : NumberDateFilterReq
    {
        //کد تفصیل
        //باید دارای 4 رقم باشد
        public string DetCode { get; set; }
        //کد معین
        //اجباری
        //باید دارای 6 رقم باشد
        //چهار رقم اول کد کلش را بیان میکند
        public string SubCode { get; set; }
    }
    public record RemainedReferReportRes
    {
        //آی دی
        public int ArtId { get; set; }
        //شماره سند
        public int SanadNo { get; set; }
        //تاریخ
        public DateTimeOffset DTNumDate { get; set; }
        //عطف
        //بیشترین تعداد کاراکتر 10 است
        public string Refer { get; set; }
        //بیشترین تعداد کاراکتر 50 است
        public string Exp { get; set; }
        //بدهکار
        public decimal Debit { get; set; }
        //بستانکار
        public decimal Credit { get; set; }
        //تشخیص
        //باید دارای دو کاراکتر باشد
        //بس'و'بد'و مقدار خالی را نشان میدهد' 
        public string Tashkhis { get; set; }
    }
    public record RemainedReferReortTotalRes : TotalDebitCredit
    {
        //تشخیص
        //باید دارای دو کاراکتر باشد
        //بس'و'بد'و مقدار خالی را نشان میدهد' 
        public string Tashkhis { get; set; }
    }
}
