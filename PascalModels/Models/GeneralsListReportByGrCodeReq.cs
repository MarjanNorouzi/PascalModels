using PascalModels.Models.BaseModels;

public record GeneralsListReportByGrCodeReq : RemainedAccReq
{
    public string GrCode { get; set; }
}

public record GeneralsListReportByGrCodeRes : DebitCreditSum
{
    public int GenCode { get; set; }
    public int GenName { get; set; }
}

public record GeneralsListReportByGrCodeTotalRes : TotalRemained
{
}
