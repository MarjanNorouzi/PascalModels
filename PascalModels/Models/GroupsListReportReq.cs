using PascalModels.Models.BaseModels;

namespace PascalModels.Models
{
    public record GroupsListReportReq : RemainedAccReq
    {
        /// <summary>
        /// از گروه
        /// </summary>
        public string GroupFrom { get; set; }
        
        public string GroupTo { get; set; }
        public int? GroupKind { get; set; }
    }
    public record GroupsListReportRes : Remained
    {
        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public string GroupKind { get; set; }
    }
    public record GroupsListReportTotalRes : TotalRemained
    {
    }
}