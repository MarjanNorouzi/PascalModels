using PascalModels.Models.BaseModels;

public record DetailsListBySubCodeReq : RemainedAccReq
{
    /// <summary>
    /// <para><em>اسم : کدمعین</em></para> 
    /// <para>تعداد ارقام: 6</para> 
    /// <para>اجباری</para> 
    /// <para>چهار رقم اول کد کلش را بیان میکند</para> 
    /// </summary>
    public string SubCode { get; set; }
}

public record DetailsListBySubCodeRes : DebitCreditSum
{
    /// <summary>
    /// <para><em>اسم : کد تفصیل</em></para> 
    /// <para>تعداد ارقام: 4</para> 
    /// </summary>
    public string DetCode { get; set; }
    //نام تفصیل
    //بیشترین تعداد کاراکتر 50 است
    /// <summary>
    /// <para><em>اسم : نام تفصیل</em></para> 
    /// <para>حداکثر تعداد کاراکتر: 50</para> 
    /// </summary>
    public string DetName { get; set; }
}

public record DetailsListBySubCodeTotalRes : TotalRemained
{
}