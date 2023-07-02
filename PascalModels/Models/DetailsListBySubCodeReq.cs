using PascalModels.Models.BaseModels;
using System.ComponentModel.DataAnnotations;

public class DetailsListBySubCodeReq : RemainedAccReq
{
    [StringLength(10)]
    public string SubCode { get; set; }
}

public class DetailsListBySubCodeRes : DebitCreditSum
{
    [StringLength(8)]
    public string DetCode { get; set; }

    [StringLength(50)]
    public string DetName { get; set; }
}

public class DetailsListBySubCodeTotalRes : TotalRemained
{
}