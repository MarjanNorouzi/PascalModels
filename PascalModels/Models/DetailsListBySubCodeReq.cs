using PascalModels.Models.BaseModels;

public class DetailsListBySubCodeReq : RemainedAccReq
{
    public string SubCode { get; set; }
}

public class DetailsListBySubCodeRes : DebitCreditSum
{
    public string DetCode { get; set; }
    public string DetName { get; set; }
}

public class DetailsListBySubCodeTotalRes : TotalRemained
{
}