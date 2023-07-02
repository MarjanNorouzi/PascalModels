using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public class GroupsListReportReq : RemainedAccReq
    {
        public string GroupFrom { get; set; }
        public string GroupTo { get; set; }
        public short GroupKind { get; set; }
    }
    public class GroupsListReportRes : Remained
    {
        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public string GroupKind { get; set; }
    }
    public class GroupsListReportTotalRes : TotalRemained
    {
    }
}