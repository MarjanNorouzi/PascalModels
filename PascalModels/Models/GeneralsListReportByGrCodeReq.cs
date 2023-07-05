using PascalModels.Models.BaseModels;

public record GeneralsListReportByGrCodeReq : RemainedAccReq
{
    //کدمعین
    //اجباری
    //باید دارای 2 رقم باشد
    public string GrCode { get; set; }
}

public record GeneralsListReportByGrCodeRes : DebitCreditSum
{
    //کد کل
    //باید دارای 4 رقم باشد
    //دورقم اول کد گروهش را بیان میکند
    public int GenCode { get; set; }
    //نام کل
    //بیشتریت تعداد کاراکتر 50 است
    public int GenName { get; set; }
}

public record GeneralsListReportByGrCodeTotalRes : TotalRemained
{
}
