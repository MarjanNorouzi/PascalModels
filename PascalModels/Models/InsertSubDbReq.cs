namespace PascalModels.Models
{
    public record InsertSubDbReq
    {
        public string GenCode { get; set; }
        public string SubCode { get; set; }
        public string SubName { get; set; }
        public bool DetKind { get; set; }
    }

    public record EditSubDbReq : InsertSubDbReq
    {
        public int SubId { get; set; }
    }
}
