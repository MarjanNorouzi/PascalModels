using PascalModels.Models.BaseModels;

public record DetailsListBySubCodeReq : RemainedAccReq
{
    public string SubCode { get; set; }
}

public record DetailsListBySubCodeRes : DebitCreditSum
{
    public string DetCode { get; set; }
    public string DetName { get; set; }
}

public record DetailsListBySubCodeTotalRes : TotalRemained
{
}