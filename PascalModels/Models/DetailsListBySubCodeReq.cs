using PascalModels.Models.BaseModels;

public record DetailsListBySubCodeReq : RemainedAccReq
{
    //کدمعین
    //اجباری
    //باید دارای 6 رقم باشد
    //چهار رقم اول کد کلش را بیان میکند
    public string SubCode { get; set; }
}

public record DetailsListBySubCodeRes : DebitCreditSum
{
    //کد تفصیل
    //باید دارای 4 رقم باشد
    public string DetCode { get; set; }
    //نام تفصیل
    //بیشترین تعداد کاراکتر 50 است
    public string DetName { get; set; }
}

public record DetailsListBySubCodeTotalRes : TotalRemained
{
}