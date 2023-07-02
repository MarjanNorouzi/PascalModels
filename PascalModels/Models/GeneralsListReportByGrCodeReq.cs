using PascalModels.Models.BaseModels;

public class GeneralsListReportByGrCodeReq : RemainedAccReq
{
    public string GrCode { get; set; }
}

public class GeneralsListReportByGrCodeRes : DebitCreditSum
{
    public int GenCode { get; set; }
    public int GenName { get; set; }
}

public class GeneralsListReportByGrCodeTotalRes : TotalRemained
{
}
