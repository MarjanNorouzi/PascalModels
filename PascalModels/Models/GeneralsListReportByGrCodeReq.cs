using System.ComponentModel.DataAnnotations;

public class GeneralsListReportByGrCodeReq : RemainedAccountReq
{
    [StringLength(2)]
    public string GrCode { get; set; }
}
