using PascalModels.Models.BaseModels;
using System.ComponentModel.DataAnnotations;

public class GeneralsListReportByGrCodeReq : RemainedAccReq
{
    [StringLength(2)]
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
