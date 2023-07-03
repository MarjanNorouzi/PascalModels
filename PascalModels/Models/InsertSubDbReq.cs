namespace PascalModels.Models
{
    public class InsertSubDbReq
    {
        public string GenCode { get; set; }
        public string SubCode { get; set; }
        public string SubName { get; set; }
        public bool DetKind { get; set; }
    }

    public class EditSubDbReq : InsertSubDbReq
    {
        public int SubId { get; set; }
    }
}
