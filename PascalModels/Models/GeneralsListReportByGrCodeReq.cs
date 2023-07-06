using PascalModels.Models.BaseModels;

public record GeneralsListReportByGrCodeReq : RemainedAccReq
{
    /// <summary>
    /// <para><em>اسم : کد گروه</em></para> 
    /// <para>تعداد ارقام: 2</para> 
    /// <para>اجباری</para> 
    /// </summary>
    public string GrCode { get; set; }
}

public record GeneralsListReportByGrCodeRes : DebitCreditSum
{
    /// <summary>
    /// <para><em>اسم : کد کل</em></para> 
    /// <para>تعداد ارقام: 4</para> 
    /// <para>اجباری</para> 
    /// <para>دو رقم اول کد گروهش را بیان میکند</para> 
    /// </summary>
    public int GenCode { get; set; }
    /// <summary>
    /// <para><em>اسم : نام کل</em></para> 
    /// <para>حداکثر تعداد کاراکتر: 50</para> 
    /// </summary>
    public int GenName { get; set; }
}

public record GeneralsListReportByGrCodeTotalRes : TotalRemained
{
}
